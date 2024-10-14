//Confirm Delete Start

$(".overlay").hide()
$(".mainconfirm").hide()
$(".green").hide()
let runOnce = false;
let deletedID = null;

function confirmDelete(deletedText, deletedid) {
    deletedID = deletedid;
    $(".overlay").fadeIn()
    $("#toBeDeleted").text(deletedText)
    $(".mainconfirm").fadeIn()
}
function closeConfirmDelete(ev) {
    ev.stopPropagation();
    $(".overlay").hide()
    $(".mainconfirm").hide()
}
function startAnimation() {

    //next part is just to animate the icon then delete the task
    if (!this.runOnce) {
        this.runOnce = true;
        $(".red").addClass("animate")
        setTimeout(() => {
            $(".red").hide()
            $(".green").show()
            setTimeout(() => {
                $(".green").addClass("animate2")
                setTimeout(() => {
                    deleteFromDB()
                }, 250);
            }, 5);
        }, 150);
    }
}
function deleteFromDB() {

    let url = "/Inventory/DeleteProduct"
    $.get(url, { id: deletedID }, () => {
        window.location.href = "/Inventory";
    });
}


// Function to open modal in edit mode
function openEditModalProduct(id, name, description, price, image, categoryID, SupplierID) {
    debugger;
    $('#productModalLabel').text("Edit Product");
    $('#addOrEditProduct').text("Edit");
    // mapping
    $('input[name="Id"]').val(id);
    $('input[name="Name"]').val(name);
    $('input[name="Description"]').val(description);
    $('input[name="Price"]').val(price);
    $('input[name="Image"]').val(image);
    $('#categorySelector').val(categoryID);
    $('#supplierSelector').val(SupplierID);

    $('#currentDiv').hide();
    $('#minDiv').hide();
    $('#maxDiv').hide();
    $('#warehouseDiv').hide();
    //$('#supplierDiv').hide();
    //$('#categoryDiv').hide();

    $('#addOrEditProductForm').attr('action', `/Inventory/UpdateProduct`);
    // Open the modal
    $('#productModal').modal('show');
}

// Reset modal back to "Add Product" mode when it's closed
$('#productModal').on('hidden.bs.modal', function () {
    debugger;
    // Reset modal title and button text for the Add mode
    $('#productModalLabel').text("Add Product");
    $('#addOrEditProduct').text("Add");
    // Clear the input field
    $('input[name="Id"]').val('');
    $('input[name="oldWareHouseID"]').val('');
    $('input[name="Name"]').val('');
    $('input[name="Description"]').val('');
    $('input[name="Price"]').val('');
    $('input[name="Image"]').val('');
    $('input[name="CurrentStock"]').val('');
    $('input[name="MinStock"]').val('');
    $('input[name="MaxStock"]').val('');

    $('#wareHouseSelector').val('Select Warehouse');
    $('#supplierSelector').val('Select Supplier');
    $('#categorySelector').val('Select Category');
    $('#currentDiv').show();
    $('#minDiv').show();
    $('#maxDiv').show();
    $('#warehouseDiv').show();

    // Reset the form action back to AddProduct
    $('#addOrEditProductForm').attr('action', '/Inventory/AddProduct');
});

//Add / Edit Product Modal End