# Different ways of appending a table 

```js

    function showBids(data) {

        $('#myTable').find('tbody').empty();
        if (data !== null) {
            $.each(JSON.parse(data), function (key, item) {

                var bidData = '<tr><td>' + item.Buyer + '</td ><td>$' + item.Price.toFixed(2).replace(/\d(?=(\d{3})+\.)/g, '$&,') + '</td></tr>';
                $('#myTable').find('tbody').append(bidData);

            });
            
        }

    }

```


```js
    function showBids(data) {


        var bidList = "";
        if (data !== null) {
            $.each(JSON.parse(data), function (key, item) {

                console.log(item.Buyer);

                bidList += '<tr>';
                bidList += '<td>' + item.Buyer + '</td>';
                bidList += '<td>' + "$" + item.Price.toFixed(2).replace(/\d(?=(\d{3})+\.)/g, '$&,') + '</td>';
                bidList += '<tr>';

            });
        }

        $('#current-bid').html(bidList);

    }
```


[Homework 7 Reference](https://github.com/swakita14/swakita14.github.io/blob/master/HW7/AJAX-WebApp/AJAX-WebApp/Scripts/ajax-giphy.js)


