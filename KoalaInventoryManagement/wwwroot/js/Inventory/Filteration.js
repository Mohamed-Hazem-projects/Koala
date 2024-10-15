$(function () {
    function fetchProducts() {
        var searchString = $('#searchInput').val();
        var searchWareHouseID = $('#wareHouseID').val();
        var searchCategoryID = $('#categoryID').val();
        var searchSupplierID = $('#supplierID').val();
        var filteredProductsList = JSON.parse($('#filteredProductsData').val());
        var productsJson = JSON.stringify(filteredProductsList);

        $.ajax({
            url: $('#getFilteredProductsUrl').val(),
            data: {
                wareHouseID: searchWareHouseID,
                categoryID: searchCategoryID,
                supplierID: searchSupplierID,
                searchString: searchString,
                showedProducts: productsJson
            },
            method: "post",
            success: function (data) {
                var tableBody = $('#productsTable tbody');
                tableBody.empty();
                appendRows(data);
            },
            error: function (xhr, status, error) {
                console.error("AJAX request failed: " + status + ", " + error);
            }
        });
    }

    function appendRows(products) {
        var tableBody = $('#productsTable tbody');
        if (!products || products.length === 0) {
            console.error("Products data is undefined or empty");
            return;
        }

        $.each(products, function (index, product) {
            var row = '<tr>' +
                '<td>' + product.name + '</td>' +
                '<td>' + product.description + '</td>' +
                '<td>$&nbsp;' + product.price + '</td>' +
                '<td>' + product.image + '</td>' +
                '<td>' +
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
                '</td>' +
                '</tr>';
            tableBody.append(row);
        });
    }

    // Debounce function to limit the number of calls
    function debounce(func, delay) {
        let timeout;
        return function (...args) {
            clearTimeout(timeout);
            timeout = setTimeout(() => func.apply(this, args), delay);
        };
    }

    $('#searchInput, #wareHouseID, #categoryID, #supplierID').on('input', debounce(fetchProducts, 300));
});
