// Confirm Delete Start

$(".overlay").hide();
$(".mainconfirm").hide();
$(".green").hide();

let deletedID = null;

function confirmDelete(deletedText, deletedid) {
    deletedID = deletedid;
    $(".overlay").fadeIn();
    $("#toBeDeleted").text(deletedText);
    $(".mainconfirm").fadeIn();
}

function closeConfirmDelete(ev) {
    ev.stopPropagation();
    $(".overlay").hide();
    $(".mainconfirm").hide();
}

function startAnimation() {
    if (!this.runOnce) {
        this.runOnce = true;
        $(".red").addClass("animate");
        setTimeout(() => {
            $(".red").hide();
            $(".green").show();
            setTimeout(() => {
                $(".green").addClass("animate2");
                setTimeout(() => {
                    deleteFromDB();
                }, 250);
            }, 5);
        }, 150);
    }
}

function deleteFromDB() {
    const url = "/Inventory/DeleteProduct";
    $.get(url, { id: deletedID })
        .done(() => {
            window.location.href = "/Inventory";
        })
        .fail(() => {
            alert("Error deleting product. Please try again."); // Error handling
        });
}

// Function to open modal in edit mode
function openEditModalProduct(id, name, description, price, image, categoryID, SupplierID) {
    $('#productModalLabel').text("Edit Product");
    $('#addOrEditProduct').text("Edit");

    // Mapping
    $('input[name="Id"]').val(id);
    $('input[name="Name"]').val(name);
    $('input[name="Description"]').val(description);
    $('input[name="Price"]').val(price);
    $('input[name="Image"]').val(image);
    $('#categorySelector').val(categoryID);
    $('#supplierSelector').val(SupplierID);

    $('#currentDiv, #minDiv, #maxDiv, #warehouseDiv').hide();

    $('#addOrEditProductForm').attr('action', `/Inventory/UpdateProduct`);

    // Open the modal
    $('#productModal').modal('show');
}

// Reset modal back to "Add Product" mode when it's closed
$('#productModal').on('hidden.bs.modal', function () {
    // Reset modal title and button text for the Add mode
    $('#productModalLabel').text("Add Product");
    $('#addOrEditProduct').text("Add");

    // Clear the input field
    $('input[name="Id"], input[name="oldWareHouseID"], input[name="Name"], input[name="Description"], input[name="Price"], input[name="Image"], input[name="CurrentStock"], input[name="MinStock"], input[name="MaxStock"]').val('');

    $('#wareHouseSelector').val('Select Warehouse');
    $('#supplierSelector').val('Select Supplier');
    $('#categorySelector').val('Select Category');
    $('#currentDiv, #minDiv, #maxDiv, #warehouseDiv').show();

    // Reset the form action back to AddProduct
    $('#addOrEditProductForm').attr('action', '/Inventory/AddProduct');
});

// Add / Edit Product Modal End
