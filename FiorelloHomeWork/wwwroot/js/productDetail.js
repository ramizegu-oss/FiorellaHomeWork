$(document).ready(function () {

    // 1. Click on a small image -> show it as the main image
    $(".thumb").click(function () {
        $("#main-img").attr("src", $(this).attr("src"));
        $(".thumb").removeClass("active");
        $(this).addClass("active");
    });

    // 2. Quantity buttons
    $("#plus").click(function () {
        var qty = parseInt($("#qty").val());
        $("#qty").val(qty + 1);
    });

    $("#minus").click(function () {
        var qty = parseInt($("#qty").val());
        if (qty > 1) {
            $("#qty").val(qty - 1);
        }
    });

    // 3. Add to cart (backend will be connected here later)
    $("#add-to-cart").click(function () {
        var name = $("#product-name").text();
        var qty = $("#qty").val();
        alert(name + " x " + qty + " added to cart");
    });

});