$(function () {
    var currentPage = 1;  // Default to the first page
    var pageSize = 10;    // Set default page size

    function fetchProducts() {
        var searchString = $('#searchInput').val();
        var searchWareHouseID = $('#wareHouseID').val();
        var searchCategoryID = $('#categoryID').val();
        var searchSupplierID = $('#supplierID').val();

        $.ajax({
            url: $('#getFilteredProductsUrl').val(),
            data: {
                wareHouseID: searchWareHouseID,
                categoryID: searchCategoryID,
                supplierID: searchSupplierID,
                searchString: searchString,
                page: currentPage,  // Pass the current page number
                pageSize: pageSize  // Pass the page size
            },
            method: "POST",
            success: function (data) {
                console.log(data);
                var tableBody = $('#productsTable tbody');
                tableBody.empty();
                appendRows(data.products, data.role);  // Assuming `data.products` contains the products
                updatePagination(data.totalPages);  // Update pagination based on `totalPages`
            },
            error: function (xhr, status, error) {
                console.error("AJAX request failed: " + status + ", " + error);
            }
        });
    }

    function appendRows(products, role) {
        var tableBody = $('#productsTable tbody');
        if (!products || products.length === 0) {
            tableBody.append('<tr><td colspan="7">No products found</td></tr>');  // Display message if no products
            return;
        }

        $.each(products, function (index, product) {
            var imageSrc = '';

            if (product.image && product.image.length > 0) {
                imageSrc = 'data:image/png;base64,' + product.image;
            } else {
                imageSrc = 'https://niteair.co.uk/wp-content/uploads/2023/08/default-product-image.png';
            }

            var row = '<tr>' +
                '<td>' + product.name + '</td>' +
                '<td>' + product.description + '</td>' +
                '<td>$&nbsp;' + product.price + '</td>' +
                '<td><img src="' + imageSrc + '" alt="Product Image" width="50" height="50" /></td>';

            var contorls = '<td>' +
                '<a href="/Inventory/ShowDetails/' + product.id + '" class="btn btn-labeled">' +
                '<i class="fa fa-info-circle color-info"></i>' +
                '</a>' +
                '</td>' +
                '<td class="btn-td edit">' +
                '<a onclick="openEditModalProduct(' + product.id + ', \'' + product.name + '\', \'' + product.description + '\', ' + product.price + ', \'' + product.image + '\', ' +
                product.categoryID + ', ' + product.supplierID + ')">' +
                '<i class="fa fa-pencil color-edit"></i>' +
                '</a>' +
                '</td>' +
                '<td class="btn-td delete">' +
                '<a onclick="confirmDelete(\'' + product.name + ' Product\', ' + product.id + ')">' +
                '<i class="fa fa-close color-danger"></i>' +
                '</a>' +
                '</td>';

            var closing = '</tr>';

            if (role != "User") {
                row += contorls;
            }
            row += closing;

            tableBody.append(row);
        });
    }

    function updatePagination(totalPages) {
        var paginationContainer = $('.pagination-container');
        paginationContainer.empty();  // Clear previous pagination

        if (totalPages > 1) {
            var pagination = '<ul class="pagination">';

            for (var i = 1; i <= totalPages; i++) {
                pagination += '<li class="page-item ' + (i === currentPage ? 'active' : '') + '">' +
                    '<a class="page-link" href="#" data-page="' + i + '">' + i + '</a>' +
                    '</li>';
            }

            pagination += '</ul>';
            paginationContainer.append(pagination);
        }
    }

    // Handle on pagination click
    $(document).on('click', '.pagination a', function (e) {
        e.preventDefault();
        currentPage = $(this).data('page');  // Get clicked page number
        fetchProducts();  // Fetch products for the clicked page
    });

    // Debounce function to limit the number of calls
    function debounce(func, delay) {
        let timeout;
        return function (...args) {
            clearTimeout(timeout);
            timeout = setTimeout(() => func.apply(this, args), delay);
        };
    }

    // Call fetchProducts when filters change with a debounce
    $('#searchInput, #wareHouseID, #categoryID, #supplierID').on('input', debounce(function () {
        currentPage = 1;  // Reset to first page when filters change
        fetchProducts();
    }, 300));

    // Initial fetch of products
    fetchProducts();
});