$(document).ready(function () {
    $('#searchInput').on('input', function () {
        var searchString = $(this).val();
        //debugger;
        var filteredProductsList = JSON.parse($('#filteredProductsData').val());
        //console.log(filteredProductsList);
        var productsJson = JSON.stringify(filteredProductsList);
        $.ajax({
            url: $('#getFilteredProductsUrl').val(),
            data: { searchString: searchString, showedProducts: productsJson },
            method: "post",
            success: function (data) {
                debugger;
                //console.log(data); // Log the entire response to check its structure
                var tableBody = $('#productsTable tbody');
                tableBody.empty();

                function appendRows(products) {
                    $.each(products, function (index, product) {
                        //debugger;
                        var row = '<tr>' +
                            '<td>' + product.name + '</td>' +
                            '<td>' + product.description + '</td>' +
                            '<td>$ ' + product.price + '</td>' +
                            '<td>' + product.image + '</td>' +
                            '<td>' + product.wareHouseName + '</td>' +
                            '<td>' + product.currentStock + '</td>' +
                            '<td>' + product.mintStock + '</td>' +
                            '<td>' + product.maxStock + '</td>' +
                            '<td>' + product.categoryName + '</td>' +
                            '<td>' + product.supplierName + '</td>' +
                            '<td class="btn-td edit">' +
                            '<a onclick="openEditModalSupplier(' + product.id + ', \'' + product.name + '\', \'' + product.description + '\', ' + (product.price / 10) + ')">' +
                            '<i class="fa fa-pencil color-muted"></i>' +
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

//$(document).ready(function () {
//    $('#searchInput').on('input', function () {
//        var searchString = $(this).val();
//        debugger;
//        var filteredProductsList = @Html.Raw(serlizedFilteredProducts);
//        console.log(filteredProductsList);
//        var productsJson = JSON.stringify(filteredProductsList);
//        $.ajax({
//            url: '@Url.Action("GetFilteredProducts", "Inventory")',
//            data: { searchString: searchString, showedProducts: productsJson },
//            success: function (data) {
//                console.log(data); // Log the entire response to check its structure
//                var tableBody = $('#productsTable tbody');
//                tableBody.empty();

//                function appendRows(products) {
//                    $.each(products, function (index, product) {
//                        var row = '<tr>' +
//                            '<td>' + product.Name + '</td>' +
//                            '<td>' + product.Description + '</td>' +
//                            '<td>' + product.Price + '</td>' +
//                            '<td><img src="' + product.ImageUrl + '" alt="Product Image" width="50" height="50"/></td>' +
//                            '<td>' + product.WareHouseName + '</td>' +
//                            '<td>' + product.CurrentStock + '</td>' +
//                            '<td>' + product.MintStock + '</td>' +
//                            '<td>' + product.MaxStock + '</td>' +
//                            '<td class="btn-td edit">' +
//                            '<a href="/Inventory/Edit/' + product.Id + '">' +
//                            '<i class="fa fa-pencil color-muted"></i>' +
//                            '</a>' +
//                            '</td>' +
//                            '<td class="btn-td delete">' +
//                            '<a href="/Inventory/Delete/' + product.Id + '">' +
//                            '<i class="fa fa-close color-danger"></i>' +
//                            '</a>' +
//                            '</td>' +
//                            '</tr>';
//                        tableBody.append(row);
//                    });

//                    // $('#wareHouseFilter option').eq(0).prop('selected', true);
//                    // $('#productFilter option').eq(0).prop('selected', true);
//                }

//                if (data && data.FilteredProducts && data.FilteredProducts.$values) {
//                    appendRows(data.FilteredProducts.$values);
//                } else if (data && data.UnFilteredProducts && data.UnFilteredProducts.$values) {
//                    appendRows(data.UnFilteredProducts.$values);
//                } else {
//                    console.error("Products data is undefined or null");
//                }
//            },
//            error: function (xhr, status, error) {
//                console.error("AJAX request failed: " + status + ", " + error);
//            }
//        });
//    });
//});