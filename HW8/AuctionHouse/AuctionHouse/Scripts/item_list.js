$(document).ready(function () {

  
    var id = document.getElementById("hidden-id").value;
    
   



     var source = "/BidApi/ItemBids?=" + id;
        
     var ajax_call = function () {
            $.ajax({
                type: "GET",
                dataType: "json",
                data: { "id": id },
                url: source,
                success: showBids,
                error: errorOnAjax

            });
      };

      var interval = 1000 * 3; // where X is your timer interval in X seconds

       window.setInterval(ajax_call, interval);

    

    function showBids(data) {

        var bidList = "";

        $.each(JSON.parse(data), function (key, item) {

            console.log(item.Buyer);

            bidList += '<tr>';
            bidList += '<td>' + item.Buyer + '</td>';
            bidList += '<td>' + "$" + item.Price.toFixed(2).replace(/\d(?=(\d{3})+\.)/g, '$&,') + '</td>';
            bidList += '<tr>';

        });

        $('#current-bid').html(bidList);

    }



    //if there is an error on the request
    function errorOnAjax() {
        console.log("error");
    }

});