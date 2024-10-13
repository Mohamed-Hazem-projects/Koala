//Confirm Delete Start

$(".overlay").hide()
$(".mainconfirm").hide()
$(".green").hide()
let runOnce = false;
let deletedID = null;
let DeleteSupplerOrCategory = null; //1 for suppliers and 2 for categories
function confirmDelete(deletedText, deletedid,whichToDelete) {
    deletedID = deletedid;
    DeleteSupplerOrCategory = whichToDelete;
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
    let url = DeleteSupplerOrCategory == 1 ? "/Suppliers/DeleteSupplier" : "/Suppliers/DeleteCategory"
    $.post(url,{ id: deletedID }, () => {
        window.location.href = "/Suppliers";
    });
}

//Confirm Delete End

//Add / Edit Category Modal Start

$("#addOrEditCategory").on('click', () => {
    $("#addOrEditCategoryForm").validate()
    if ($("#addOrEditCategoryForm").valid()) {
        $("#addOrEditCategoryForm").trigger("submit")
    } 
})

// Function to open modal in edit mode
function openEditModal(id,name) {
    // Change the modal header to "Edit Category"
    $('#categoryModalLabel').text("Edit Category");
    // Change the button text to "Save Changes" for editing
    $('#addOrEditCategory').text("Edit");
    // Set the input field to the clicked category's name
    $('input[name="Id"]').val(id);
    $('input[name="Name"]').val(name);
    // Change the form action to the EditCategory action with the categoryId
    $('#addOrEditCategoryForm').attr('action', `/Suppliers/UpdateCategory`);
    // Open the modal
    $('#categoryModal').modal('show');
}

// Reset modal back to "Add Category" mode when it's closed
$('#categoryModal').on('hidden.bs.modal', function () {
    // Reset modal title and button text for the Add mode
    $('#categoryModalLabel').text("Add Category");
    $('#addOrEditCategory').text("Add");
    // Clear the input field
    $('input[name="Name"]').val('');
    $('input[name="Id"]').val('');
    // Reset the form action back to AddCategory
    $('#addOrEditCategoryForm').attr('action', '/Suppliers/AddCategory');
});

//Add / Edit Category Modal End

//Add / Edit Supplier Modal Start

$("#addOrEditSupplier").on('click', () => {
    if ($("#addOrEditSupplierForm").valid()) {
        $("#addOrEditSupplierForm").trigger("submit")
    }
})

// Function to open modal in edit mode

    function openEditModalSupplier(id, name, phone, email, rating) {
        // Change the modal header to "Edit Category"
        $('#supplierModalLabel').text("Edit Supplier");
        // Change the button text to "Save Changes" for editing
        $('#addOrEditSupplier').text("Edit");
        // mapping
        $('input[name="Id"]').val(id);
        $('input[name="Name"]').val(name);
        $('input[name="Phone_Number"]').val(phone);
        $('input[name="Email_Address"]').val(email);
        $('input[name="Rating"]').val(rating);
        // Change the form action to the EditCategory action with the categoryId
        $('#addOrEditSupplierForm').attr('action', `/Suppliers/UpdateSupplier`);
        // Open the modal
        $('#supplierModal').modal('show');
    }

    // Reset modal back to "Add Category" mode when it's closed
    $('#supplierModal').on('hidden.bs.modal', function () {
        // Reset modal title and button text for the Add mode
        $('#supplierModalLabel').text("Add Supplier");
        $('#addOrEditSupplier').text("Add");
        // Clear the input field
        $('input[name="Name"]').val('');
        $('input[name="Id"]').val('');
        $('input[name="Phone_Number"]').val('');
        $('input[name="Email_Address"]').val('');
        $('input[name="Rating"]').val('');
        // Reset the form action back to AddCategory
        $('#addOrEditSupplierForm').attr('action', '/Suppliers/AddSupplier');
    });
    //Add / Edit Supplier Modal End

