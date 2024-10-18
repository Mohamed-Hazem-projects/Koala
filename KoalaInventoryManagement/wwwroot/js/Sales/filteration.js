var timer;
var typingStopped = 400;
const suggestionsUrl = $('#url').attr('data-productSuggestionsUrl');
const addUrl = $('#url').attr('data-addSaleUrl');
const updatedUrl = $('#url').attr('data-updatedDataUrl');
const baseUrl = $('#url').attr('data-base-url');
const options = {
  year: 'numeric',
  month: '2-digit',
  day: '2-digit',
  hour: '2-digit',
  minute: '2-digit',
  hour12: true, // Use 12-hour format
  timeZone: 'Africa/Cairo',
};
$('.overlay').hide();
$('.mainconfirm').hide();
$('.green').hide();
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
    debugger;
    // Check if the click is outside of the dropdown or the input
    if (
      !target.closest('#productSuggestions').length &&
      !target.closest('#productName').length
    ) {
      $('#productSuggestions').hide();
    }
    if (!target.closest('.mainconfirm').length) {
      $('.overlay').fadeOut();
      $('.mainconfirm').fadeOut();
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

  /* Delete Modal and Animation */
  $(document).on('click', '.sales-id-delete-button', function (e) {
    debugger;
    e.stopPropagation();
    const id = $(this).attr('data-id');
    $('#confirm-delete').attr('data-id', id);
    $('.overlay').fadeIn();
    $('.mainconfirm').fadeIn();
  });

  $('#close-delete-btn').click(function (e) {
    debugger;
    e.stopPropagation();
    $('.overlay').fadeOut();
    $('.mainconfirm').fadeOut();
  });

  $('.close2').click(function (e) {
    e.stopPropagation();
    $('.overlay').fadeOut();
    $('.mainconfirm').fadeOut();
  });

  $('#confirm-delete').click(function () {
    debugger;

    this.runOnce = true;
    $('.red').addClass('animate');
    setTimeout(() => {
      $('.red').hide();
      $('.green').show();
      setTimeout(() => {
        $('.green').addClass('animate2');
        setTimeout(() => {
          deleteFromDB();
          $('.overlay').fadeOut();
          $('.mainconfirm').fadeOut();
          setTimeout(() => {
            resetState(); // Reset everything to the initial state
          }, 450);
        }, 250);
      }, 5);
    }, 150);
  });

  function resetState() {
    // Show the red element again and hide the green one
    $('.red').removeClass('animate');
    $('.red').show();
    $('.green').hide();

    // Remove the animate2 class from the green element
    $('.green').removeClass('animate2');

    // Reset any other UI elements as needed
  }

  function deleteFromDB() {
    debugger;
    const url = '/Sales/DeleteSales';
    const id = $('#confirm-delete').attr('data-id');
    $.ajax({
      url: '/Sales/DeleteSales',
      method: 'POST',
      data: { salesId: id },
      success: function (updatedData) {
        console.log(updatedData);
        fetchUpdatedData();
      },
      error: function (error) {
        alert('Error deleting product. Please try again.'); // Error handling
      },
    });
  }
  /* End of Delete Modal and Animation */

  function fetchUpdatedData() {
    const pageNumber = $('#active').text();
    obj = { pageNumber: pageNumber };
    $.ajax({
      url: updatedUrl,
      method: 'POST',
      data: obj,
      success: function (updatedData) {
        console.log(updatedData);
        debugger;
        $('#salesTable tbody').empty();
        $.each(updatedData.sales, function (i, obj) {
          const row = ` <tr>
                    <td>${obj.productName}</td>
                    <td>${obj.wareHouseName}</td>
                    <td>${obj.itemsSold}</td>
                    <td>${obj.totalPrice}</td>
                    <td>${new Date(obj.saleDate)
                      .toLocaleString('en-US', options)
                      .replace(',', '')}</td>
                    <td class="btn-td delete text-center">
                      <a class="sales-id-delete-button" data-id="${
                        obj.id
                      }"><i class="fa fa-close color-danger"></i></a>
                    </td>
                  </tr>`;
          $('#salesTable tbody').append(row);
        });

        $('#navigation-btns').empty();
        let navigationBtns = `<li><span class="mx-3" id="page-item-count">${
          updatedData.pageIndex == updatedData.pageNumbers
            ? updatedData.totalItems
            : updatedData.pageIndex > 1
            ? updatedData.itemCountPerPage * updatedData.pageIndex
            : updatedData.itemCountPerPage
        } out of ${updatedData.totalItems}</span></li>
                <li class="page-item ${
                  !updatedData.hasPreviousPage ? 'disabled' : ''
                }" id="previous-button"><a class="page-link"
                    href="${baseUrl}?pageNumber=${
          updatedData.pageIndex - 1
        }">Previous</a></li> `;
        for (let i = 1; i <= updatedData.pageNumbers; i++) {
          navigationBtns += `<li class="page-item ${
            i == updatedData.pageIndex ? 'active' : ''
          }">
                    <a class="page-link" href="${baseUrl}?pageNumber=${i}" id="${
            i == updatedData.pageIndex ? 'active' : i
          }">${i}</a>
                  </li> `;
        }
        navigationBtns += `<li class="page-item ${
          !updatedData.hasNextPage ? 'disabled' : ''
        }" id="next-button"><a class="page-link"
                    href="${baseUrl}?pageNumber=${
          updatedData.pageIndex + 1
        }">Next</a></li>`;

        $('#navigation-btns').append(navigationBtns);
      },
      error: function (error) {
        console.log('Error: ', error);
      },
    });
  }
});
