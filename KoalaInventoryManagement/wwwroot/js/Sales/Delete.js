
        //Confirm Delete Start

    $(".overlay").hide()
    $(".mainconfirm").hide()
    $(".green").hide()
    let runOnce = false;
    let deletedID = null;
    let DeleteSupplerOrCategory = null; //1 for suppliers and 2 for categories
    function confirmDelete(deletedText, deletedid, whichToDelete) {
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
        let url = DeleteSupplerOrCategory == 1 ? "/Sales/DeleteSales" : "/Sales/DeleteSales"
    $.post(url, {id: deletedID }, () => {
        window.location.href = "/Sales";
            });
        }

//Confirm Delete End