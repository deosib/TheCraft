var Global = Global || {
    VER: "?v=0.1",
    API: "//localhost/api",
    MVC: "//localhost/craft",
    CurrentTab: 0,
    MaxTab: 1
};

Global.Init = function () {
    $("#banner-slider").owlCarousel({
        items: 4,
        autoplay: true,
        autoPlaySpeed: 3000,
        autoPlayTimeout: 3000,
        autoplayHoverPause: true,
        loop: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 3
            },
            1000: {
                items: 5
            }
        }
    });
}
