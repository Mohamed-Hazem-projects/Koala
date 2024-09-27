//next part is for the sidebar

//ba7ot ta8yeer el sidebar fl session storage 3nd el client
//3shan myt8yrsh lma yn2l mbeen el views
let sideBarSize = sessionStorage.getItem("sideBarSize") || "big";
sessionStorage.setItem("sideBarSize", sideBarSize);

//this part initializes the sidebar with the correct size the timeouts are
//to avoid animations on load
if (sideBarSize === "small") {
    $(".main").addClass("no-transition");
    setTimeout(() => {
        $(".main").addClass("size-change");
        setTimeout(() => {
            $(".main").removeClass("no-transition");
            $("#left").hide();
        }, 2)
    },1)
} else {
    $("#right").hide();
}

$(".change-sidebar").on("click", function () {
    
    sideBarSize = sessionStorage.getItem("sideBarSize") === "big" ? "small" : "big";
    sessionStorage.setItem("sideBarSize", sideBarSize);

    $("#right").toggle();
    $("#left").toggle();
    $(".main").toggleClass("size-change");
});

//next part is for the loading spinner
$(window).on('beforeunload', function () {
    $("#preloader").fadeIn(50);
});
$(window).on('load', function () {
    $("#preloader").fadeOut("slow");
});