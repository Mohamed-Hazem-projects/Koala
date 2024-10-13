/// <reference path="../../lib/jquery/jquery.d.ts" />
var timer;
var typingStopped = 400;
const suggestionsUrl = $('#url').attr('data-productSuggestionsUrl');
const addUrl = $('#url').attr('data-addSaleUrl');
const updatedUrl = $('#url').attr('data-updatedDataUrl');
const options = {
  year: 'numeric',
  month: '2-digit',
  day: '2-digit',
  hour: '2-digit',
  minute: '2-digit',
  hour12: true, // Use 12-hour format
  timeZone: 'Africa/Cairo',
};
$(document).ready(function () {
  $('#warehouseNames').change(function () {
    $('#warehouse-error').hide();
  });

  $('#productName').on('input', function () {
    clearTimeout(timer);
    const search = $(this).val();
    const warehouseId = $('#warehouseNames').val();
    $('#productName').removeAttr('data-id');
    $('#productName').removeAttr('data-warehouse-id');
    $('#quantity-error').hide();
    timer = setTimeout(function () {
      if (search.length > 3) {
        $.ajax({
          url: suggestionsUrl,
          method: 'POST',
          data: { name: search, warehouseId: warehouseId },
          success: function (data) {
            $('#productSuggestions').empty(); // Clear previous suggestions
            console.log(data);
            if (data.length === 0) {
              $('#productSuggestions').append(
                '<a class="dropdown-item no-click">No products found</a>'
              );
            } else {
              $.each(data, function (i, obj) {
                $('#productSuggestions').append(
                  '<a class="dropdown-item" data-id="' +
                    `${obj.id}` +
                    '" data-price="' +
                    `${obj.price}` +
                    '" data-stock="' +
                    `${obj.currentStock}` +
                    '" data-warehouse-id="' +
                    `${obj.wareHouseID}` +
                    '">' +
                    obj.name +
                    '</a>'
                );
              });
            }
            $('#productSuggestions').show();
          },
          error: function (error) {
            console.error('Error:', error);
          },
        });
      } else {
        $('#productSuggestions').hide(); // Hide if less than 3 characters
      }
    }, typingStopped);
  });

  $(document).click(function (e) {
    /* This function checks if the user clicked the dropdown menu of not*/
    var target = $(e.target);

    // Check if the click is outside of the dropdown or the input
    if (
      !target.closest('#productSuggestions').length &&
      !target.closest('#productName').length
    ) {
      $('#productSuggestions').hide();
    }
  });

  // Prevent the dropdown from closing when clicking inside the input or the dropdown
  $('#productName').click(function (e) {
    e.stopPropagation(); // Prevents the document click event from being triggered
  });

  $(document).on('click', '.dropdown-item', function (e) {
    if (
      $(this).hasClass('no-click') ||
      $(this).text() === 'No products found'
    ) {
      e.preventDefault(); // Prevent clicking
      return; // Exit the handler early for the "No products found" item
    }
    console.log('Click event fired');
    e.preventDefault(); // This prevents the default action of the anchor tag which is to navigate to another page or same page
    const productId = $(this).attr('data-id');
    const price = $(this).attr('data-price');
    const stock = $(this).attr('data-stock');
    const wareHouseID = $(this).attr('data-warehouse-id');
    $('#productName').val($(this).text());
    $('#productSuggestions').hide();
    $('#price').val(price);
    $('#stock').val(stock);
    $('#quantity').val('1');
    $('#totalPrice').val(price);
    $('#add-button').prop('disabled', false);
    $('#productName').attr('data-id', productId);
    $('#productName').attr('data-warehouse-id', wareHouseID);
  });

  $('#quantity').on('input', function () {
    /* This function is invoked when a user enters a value for the
        quantity and calculates the Price input field and the TotalPrice input field. */
    const quantity = +$(this).val();
    const stock = +$('#stock').val();
    // Check if quantity is greater than stock
    if (quantity > stock || quantity === 0) {
      // Show error message and disable the add-button button
      $('#quantity-error').show();
      $('#add-button').prop('disabled', true);
    } else {
      // Hide error message and enable the add-button button if valid
      $('#quantity-error').hide();
      $('#add-button').prop('disabled', false);
    }
    const price = +$('#price').val();
    const total = price * quantity;
    $('#totalPrice').val(total);
  });

  $('#addModal').on('show.bs.modal', function () {
    $('#add-button').prop('disabled', true);
  });

  // Reset Modal Function
  $('#addModal').on('hide.bs.modal', function () {
    // Reset the form fields or any dynamic content inside the modal

    $('#warehouseNames').val('default');
    $('#productName').val('');
    $('#price').val('');
    $('#totalPrice').val('');
    $('#quantity').val('');
    $('#stock').val('');
    $('#quantity-error').hide();
    $('#add-button').prop('disabled', true);
  });

  // Function to Add a new Sale
  $('#add-button').click(function () {
    const productId = $('#productName').attr('data-id');
    const warehouseId = $('#warehouseNames').val();
    const totalPrice = $('#totalPrice').val();
    const quantity = $('#quantity').val();
    const stock = $('#stock').val();
    debugger;
    const saleObj = {
      ProductId: productId,
      WareHouseId: warehouseId,
      ItemsSold: quantity,
      TotalPrice: totalPrice,
    };
    if (productId === undefined) {
      $('#product-error').show();
      return;
    }
    if (warehouseId === 'default') {
      $('#warehouse-error').show();
      return;
    }
    $.ajax({
      url: addUrl,
      method: 'POST',
      data: saleObj,
      success: function (data) {
        fetchUpdatedData();
        $('#addModal').modal('hide');
      },
      error: function (error) {
        console.error('Error:', error);
      },
    });
  });

  function fetchUpdatedData() {
    const pageNumber = $('#active').text();
    obj = { pageNumber: pageNumber };
    debugger;
    $.ajax({
      url: updatedUrl,
      method: 'POST',
      data: obj,
      success: function (updatedData) {
        console.log(updatedData);
        $('#salesTable tbody').empty();
        $.each(updatedData, function (i, obj) {
          const row = ` <tr>
                    <td>${obj.productName}</td>
                    <td>${obj.wareHouseName}</td>
                    <td>${obj.itemsSold}</td>
                    <td>${obj.totalPrice}</td>
                    <td>${new Date(obj.saleDate)
                      .toLocaleString('en-US', options)
                      .replace(',', '')}</td>
                    <td class="btn-td delete text-center">
                      <a id="sales-id" data-id="${
                        obj.id
                      }"><i class="fa fa-close color-danger"></i></a>
                    </td>
                  </tr>`;
          $('#salesTable tbody').append(row);
        });
      },
      error: function (error) {
        console.log('Error: ', error);
      },
    });
  }
});
