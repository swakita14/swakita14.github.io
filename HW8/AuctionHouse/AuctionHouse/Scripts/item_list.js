$(document).ready(function () {


    var id = document.getElementById("hidden-id").value;

    
  
     var source = "/BidApi/ItemBids/" + id;

    console.log(source)
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

      var interval = 1000 * 5; // where X is your timer interval in X seconds

       window.setInterval(ajax_call, interval);

    

    function showBids(data) {

        $('#myTable').find('tbody').empty();
        if (data !== null) {
            $.each(JSON.parse(data), function (key, item) {

                var bidData = '<tr><td>' + item.Buyer + '</td ><td>$' + item.Price.toFixed(2).replace(/\d(?=(\d{3})+\.)/g, '$&,') + '</td></tr>';
                $('#myTable').find('tbody').append(bidData);

            });
            
        }

    }



    //if there is an error on the request
    function errorOnAjax() {
        console.log("error");
    }

});