$(function () {
    $('#searchInput').on('input', function () {
        var searchString = $(this).val();
        var searchWareHouseID = $('#wareHouseID').val();
        var searchCategoryID = $('#categoryID').val();
        var searchSupplierID = $('#supplierID').val();
        //debugger;
        var filteredProductsList = JSON.parse($('#filteredProductsData').val());
        //console.log(filteredProductsList);
        var productsJson = JSON.stringify(filteredProductsList);
        $.ajax({
            url: $('#getFilteredProductsUrl').val(),
            data: { wareHouseID: searchWareHouseID, categoryID: searchCategoryID, supplierID: searchSupplierID, searchString: searchString, showedProducts: productsJson },
            method: "post",
            success: function (data) {
                //debugger;
                //console.log(data); // Log the entire response to check its structure
                var tableBody = $('#productsTable tbody');
                tableBody.empty();

                function appendRows(products) {
                    $.each(products, function (index, product) {
                        //debugger;
                        var row = '<tr>' +
                            '<td>' + product.name + '</td>' +
                            '<td>' + product.description + '</td>' +
                            '<td>$&nbsp;' + product.price + '</td>' +
                            '<td>' + product.image + '</td>' +
                            '<td>' + product.wareHouseName + '</td>' +
                            '<td>' + product.currentStock + '</td>' +
                            '<td>' + product.mintStock + '</td>' +
                            '<td>' + product.maxStock + '</td>' +
                            '<td>' + product.categoryName + '</td>' +
                            '<td>' + product.supplierName + '</td>' +
                            '<td>' +
                            '<a href="/Inventory/ShowDetails/' + product.id + '" class="btn btn-labeled">' +
                            '<i class="fa fa-info-circle color-info"></i>' +
                            '</a>' +
                            '</td>' +
                            '<td class="btn-td edit">' +
                            '<a onclick="openEditModalProduct(' + product.id + ', ' + product.wareHouseID + ', ' + product.categoryID + ', ' + product.supplierID + ', \'' +
                            product.name + '\', \'' + product.description + '\', ' + product.price + ', \'' + product.image + '\', ' +
                            product.currentStock + ', ' + product.mintStock + ', ' + product.maxStock + ', \'' + product.categoryName + '\', \'' +
                            product.supplierName + '\')">' +
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

                    // $('#wareHouseFilter option').eq(0).prop('selected', true);
                    // $('#productFilter option').eq(0).prop('selected', true);
                }

                if (data) {
                    appendRows(data);
                } else {
                    console.error("Products data is undefined or null");
                }
            },
            error: function (xhr, status, error) {
                console.error("AJAX request failed: " + status + ", " + error);
            }
        });
    });
    $('#wareHouseID').on('input', function () {
        var searchWareHouseID = $(this).val();
        var searchString = $('#searchInput').val();
        var searchCategoryID = $('#categoryID').val();
        var searchSupplierID = $('#supplierID').val();
        debugger;
        var filteredProductsList = JSON.parse($('#filteredProductsData').val());
        console.log(filteredProductsList);
        var productsJson = JSON.stringify(filteredProductsList);
        $.ajax({
            url: $('#getFilteredProductsUrl').val(),
            data: { wareHouseID: searchWareHouseID, categoryID: searchCategoryID, supplierID: searchSupplierID, searchString: searchString, showedProducts: productsJson },
            method: "post",
            success: function (data) {
                debugger;
                console.log(data); // Log the entire response to check its structure
                var tableBody = $('#productsTable tbody');
                tableBody.empty();

                function appendRows(products) {
                    $.each(products, function (index, product) {
                        debugger;
                        var row = '<tr>' +
                            '<td>' + product.name + '</td>' +
                            '<td>' + product.description + '</td>' +
                            '<td>$&nbsp;' + product.price + '</td>' +
                            '<td>' + product.image + '</td>' +
                            '<td>' + product.wareHouseName + '</td>' +
                            '<td>' + product.currentStock + '</td>' +
                            '<td>' + product.mintStock + '</td>' +
                            '<td>' + product.maxStock + '</td>' +
                            '<td>' + product.categoryName + '</td>' +
                            '<td>' + product.supplierName + '</td>' +
                            '<td>' +
                            '<a href="/Inventory/ShowDetails/' + product.id + '" class="btn btn-labeled">' +
                            '<i class="fa fa-info-circle color-info"></i>' +
                            '</a>' +
                            '</td>' +
                            '<td class="btn-td edit">' +
                            '<a onclick="openEditModalProduct(' + product.id + ', ' + product.wareHouseID + ', ' + product.categoryID + ', ' + product.supplierID + ', \'' +
                            product.name + '\', \'' + product.description + '\', ' + product.price + ', \'' + product.image + '\', ' +
                            product.currentStock + ', ' + product.mintStock + ', ' + product.maxStock + ', \'' + product.categoryName + '\', \'' +
                            product.supplierName + '\')">' +
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

                    // $('#wareHouseFilter option').eq(0).prop('selected', true);
                    // $('#productFilter option').eq(0).prop('selected', true);
                }

                if (data) {
                    appendRows(data);
                } else {
                    console.error("Products data is undefined or null");
                }
            },
            error: function (xhr, status, error) {
                console.error("AJAX request failed: " + status + ", " + error);
            }
        });
    });
    $('#categoryID').on('input', function () {
        var searchCategoryID = $(this).val();
        var searchString = $('#searchInput').val();
        var searchWareHouseID = $('#wareHouseID').val(); 
        var searchSupplierID = $('#supplierID').val();
        debugger;
        var filteredProductsList = JSON.parse($('#filteredProductsData').val());
        console.log(filteredProductsList);
        var productsJson = JSON.stringify(filteredProductsList);
        $.ajax({
            url: $('#getFilteredProductsUrl').val(),
            data: { wareHouseID: searchWareHouseID, categoryID: searchCategoryID, supplierID: searchSupplierID, searchString: searchString, showedProducts: productsJson },
            method: "post",
            success: function (data) {
                debugger;
                console.log(data); // Log the entire response to check its structure
                var tableBody = $('#productsTable tbody');
                tableBody.empty();

                function appendRows(products) {
                    $.each(products, function (index, product) {
                        //debugger;
                        var row = '<tr>' +
                            '<td>' + product.name + '</td>' +
                            '<td>' + product.description + '</td>' +
                            '<td>$&nbsp;' + product.price + '</td>' +
                            '<td>' + product.image + '</td>' +
                            '<td>' + product.wareHouseName + '</td>' +
                            '<td>' + product.currentStock + '</td>' +
                            '<td>' + product.mintStock + '</td>' +
                            '<td>' + product.maxStock + '</td>' +
                            '<td>' + product.categoryName + '</td>' +
                            '<td>' + product.supplierName + '</td>' +
                            '<td>' +
                            '<a href="/Inventory/ShowDetails/' + product.id + '" class="btn btn-labeled">' +
                            '<i class="fa fa-info-circle color-info"></i>' +
                            '</a>' +
                            '</td>' +
                            '<td class="btn-td edit">' +
                            '<a onclick="openEditModalProduct(' + product.id + ', ' + product.wareHouseID + ', ' + product.categoryID + ', ' + product.supplierID + ', \'' +
                            product.name + '\', \'' + product.description + '\', ' + product.price + ', \'' + product.image + '\', ' +
                            product.currentStock + ', ' + product.mintStock + ', ' + product.maxStock + ', \'' + product.categoryName + '\', \'' +
                            product.supplierName + '\')">' +
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

                    // $('#wareHouseFilter option').eq(0).prop('selected', true);
                    // $('#productFilter option').eq(0).prop('selected', true);
                }

                if (data) {
                    appendRows(data);
                } else {
                    console.error("Products data is undefined or null");
                }
            },
            error: function (xhr, status, error) {
                console.error("AJAX request failed: " + status + ", " + error);
            }
        });
    });
    $('#supplierID').on('input', function () {
        var searchSupplierID = $(this).val();
        var searchString = $('#searchInput').val();
        var searchWareHouseID = $('#wareHouseID').val();
        var searchCategoryID = $('#categoryID').val();
        debugger;
        var filteredProductsList = JSON.parse($('#filteredProductsData').val());
        console.log(filteredProductsList);
        var productsJson = JSON.stringify(filteredProductsList);
        $.ajax({
            url: $('#getFilteredProductsUrl').val(),
            data: { wareHouseID: searchWareHouseID, categoryID: searchCategoryID, supplierID: searchSupplierID, searchString: searchString, showedProducts: productsJson },
            method: "post",
            success: function (data) {
                debugger;
                console.log(data); // Log the entire response to check its structure
                var tableBody = $('#productsTable tbody');
                tableBody.empty();

                function appendRows(products) {
                    $.each(products, function (index, product) {
                        //debugger;
                        var row = '<tr>' +
                            '<td>' + product.name + '</td>' +
                            '<td>' + product.description + '</td>' +
                            '<td>$&nbsp;' + product.price + '</td>' +
                            '<td>' + product.image + '</td>' +
                            '<td>' + product.wareHouseName + '</td>' +
                            '<td>' + product.currentStock + '</td>' +
                            '<td>' + product.mintStock + '</td>' +
                            '<td>' + product.maxStock + '</td>' +
                            '<td>' + product.categoryName + '</td>' +
                            '<td>' + product.supplierName + '</td>' +
                            '<td>' +
                            '<a href="/Inventory/ShowDetails/' + product.id + '" class="btn btn-labeled">' +
                            '<i class="fa fa-info-circle color-info"></i>' +
                            '</a>' +
                            '</td>' +
                            '<td class="btn-td edit">' +
                            '<a onclick="openEditModalProduct(' + product.id + ', ' + product.wareHouseID + ', ' + product.categoryID + ', ' + product.supplierID + ', \'' +
                            product.name + '\', \'' + product.description + '\', ' + product.price + ', \'' + product.image + '\', ' +
                            product.currentStock + ', ' + product.mintStock + ', ' + product.maxStock + ', \'' + product.categoryName + '\', \'' +
                            product.supplierName + '\')">' +
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

                    // $('#wareHouseFilter option').eq(0).prop('selected', true);
                    // $('#productFilter option').eq(0).prop('selected', true);
                }

                if (data) {
                    appendRows(data);
                } else {
                    console.error("Products data is undefined or null");
                }
            },
            error: function (xhr, status, error) {
                console.error("AJAX request failed: " + status + ", " + error);
            }
        });
    });
});