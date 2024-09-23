//next part is for the sidebar
$("#right").hide();
$(".change-sidebar").on("click", function () {
    $("#right").toggle();
    $("#left").toggle();
    $(".main").toggleClass("size-change")
});

