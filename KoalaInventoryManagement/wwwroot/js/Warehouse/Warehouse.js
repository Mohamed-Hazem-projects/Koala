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
    const url = "/Warehouse/Delete";
    $.get(url, { id: deletedID })
        .done(() => {
            window.location.href = "/Warehouse";
        })
        .fail(() => {
            alert("Error deleting warehouse. Please try again."); // Error handling
        });
}



$("#addOrEditWarehouse").on('click', () => {
    $("#addOrEditWarehouseForm").validate()
    if ($("#addOrEditWarehouseForm").valid()) {
        $("#addOrEditWarehouseForm").trigger("submit")
    }
})

// Function to open modal in edit mode
function openEditModalWarehouse(id, name) {
    $('#warehouseModalLabel').text("Edit warehouse");
    $('#addOrEditWarehouse').text("Edit");

    // Mapping
    $('input[name="Id"]').val(id);
    $('input[name="Name"]').val(name);
  

    $('#addOrEditWarehouseForm').attr('action', `/Warehouse/Update`);

    // Open the modal
    $('#warehouseModal').modal('show');
}

// Reset modal back to "Add Warehouse " mode when it's closed
$('#warehouseModal').on('hidden.bs.modal', function () {
    // Reset modal title and button text for the Add mode
    $('#warehouseModalLabel').text("Add warehouse");
    $('#addOrEditWarehouse').text("Add");

    // Clear the input field
    $('input[name="Id"], input[name="Name"]').val('');

   

    // Reset the form action back to Addwarehouse
    $('#addOrEditWarehouseForm').attr('action', '/Warehouse/Add');
});

// Add / Edit warehouse Modal End
