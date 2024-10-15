function labeleffect(element) {
    if ($("#Email").val()) {
        $("#Email").addClass("touched")
    } else {
        $("#Email").removeClass("touched")
    }
    if ($("#Password").val()) {
        $("#Password").addClass("touched")
    } else {
        $("#Password").removeClass("touched")
    }
}
function toggleCheckbox() {
    $("#rememberMe").trigger("click")
}