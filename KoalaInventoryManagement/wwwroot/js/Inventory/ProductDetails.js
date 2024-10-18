$(function () {
    $('.editWarehouseBtn').click(function () {
        $('#editWareHouseID').val($(this).data('id'));
        $('#editProductID').val($(this).data('product-id'));
        console.log($('#editProductID').val());
        $('#editCurrentStock').val($(this).data('current-stock'));
        $('#editMinStock').val($(this).data('min-stock'));
        $('#editMaxStock').val($(this).data('max-stock'));

        $('#editWarehouseModal').modal('show');
    });

    $('#showWarehouseBtn').click(function () {
        // Slide in the warehouse card next to the product card
        $('.warehouse-card').css({
            display: 'block',
            opacity: 0,
            position: 'relative',
            transform: 'translateX(50px)' // Start slightly to the right
        }).animate({
            opacity: 1,
            transform: 'translateX(0)' // Slide into place
        }, 400, function () {
            // Check if the warehouse card is taller than the product card
            var productCardHeight = $('.product-card').outerHeight();
            var warehouseCardHeight = $('.warehouse-card').outerHeight();

            // If the warehouse card is taller, adjust the position of the product card
            if (warehouseCardHeight > productCardHeight) {
                $('.product-card').animate({
                    top: (warehouseCardHeight - productCardHeight) / 2 // Center vertically
                }, 300);
            }
        }); // Animation duration
    });

    // Back button functionality to hide the warehouse card
    $('.back-button').click(function () {
        $('.warehouse-card').animate({
            opacity: 0,
            transform: 'translateX(50px)' // Slide out to the right
        }, 400, function () {
            $(this).css('display', 'none'); // Hide the card after animation
            // Reset the product card position
            $('.product-card').animate({
                top: 0 // Reset position
            }, 300);
        });
    });
});