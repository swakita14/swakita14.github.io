$(document).ready(function () {

    alert("Hello World");

    $.ajax({
        type: "GET",
        dataType: "json",
        data: { "id": lastitem },
        url: source,
        success: showBids,
        error: errorOnAjax

    });

    function showBids(data) {

    }

    //if there is an error on the request
    function errorOnAjax() {
        console.log("error");
    }

});