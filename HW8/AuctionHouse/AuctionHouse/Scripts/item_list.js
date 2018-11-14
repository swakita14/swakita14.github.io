$(document).ready(function () {

    //alert("Hello World");
    var id = document.getElementById("hidden-id").value;
    
    //alert(id);

    var source = "/BidApi/ItemBids?=" + id;

    

        $.ajax({
            type: "GET",
            dataType: "json",
            data: { "id": id },
            url: source,
            success: showBids,
            error: errorOnAjax

        });


    //var interval = 1000 * 4; // where X is your timer interval in X seconds

    //window.setInterval(ajax_call, interval);

    function showBids(data) {

        alert(data);

    }

    //if there is an error on the request
    function errorOnAjax() {
        console.log("error");
    }

});