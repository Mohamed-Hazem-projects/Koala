/// <reference path="../../lib/jquery/jquery.d.ts" />
var timer;
var typingStopped = 400;
const url = $('#url').attr('data-productSuggestionsUrl');
$(document).ready(function () {
  // $('#warehouseNames').change(function () {
  //   const warehouseid = $(this).val();
  //   $.ajax({
  //     url: url,
  //     type: 'POST',
  //     data: { warehouseId: warehouseid },
  //     success: function (data) {
  //       console.log(data);
  //     },
  //     error: function (error) {
  //       console.error('Error:', error);
  //     },
  //   });
  // });

  $('#productName').on('input', function () {
    clearTimeout(timer);
    const search = $(this).val();
    const warehouseId = $('#warehouseNames').val();
    timer = setTimeout(function () {
      if (search.length > 3) {
        $.ajax({
          url: url,
          type: 'POST',
          data: { name: search, warehouseId: warehouseId },
          success: function (data) {
            debugger;
            console.log(data);
            $('#productSuggestions').empty(); // Clear previous suggestions
            if (data.length === 0) {
              $('#productSuggestions').append(
                '<a class="dropdown-item">No products found</a>'
              );
            } else {
              $.each(data, function (i, obj) {
                $('#productSuggestions').append(
                  '<a class="dropdown-item" data-id="' +
                    obj.product.id +
                    '" data-price="' +
                    obj.product.price +
                    '">' +
                    obj.product.name +
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
    console.log('Click event fired');
    e.preventDefault(); // This prevents the default action of the anchor tag which is to navigate to another page or same page
    const id = $(this).attr('data-id');
    const price = $(this).attr('data-price');
    console.log(id, price);
    $('#productName').val($(this).text());
    $('#productSuggestions').hide();
    $('#price').val(price);
    $('#totalPrice').val(price);
  });

  $('#quantity').on('input', function () {
    /* This function is invoked when a user enters a value for the
    quantity and calculates the Price input field and the TotalPrice input field. */
    const price = $('#price').val();
    const quantity = $(this).val();
    const total = price * quantity;
    $('#totalPrice').val(total);
  });
});
