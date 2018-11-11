$(document).ready(function ()
{
    $('#text-input').bind('keypress', function (e)
    {

        //user hit a space bar
        if (e.which === 32)
        {
            giphySearch();
            e.preventDefault;
        }

        //What to do when the space bar is pressed 
        function giphySearch()
        {
            //gets the value of the user input
            var txt = $('#text-input').val();
            //get ths last item that is typed 
            var lastitem = txt.split(" ").pop();

            //routing it to my custome controller to send request 
            var source = "Translate/Sticker/" + txt; //Source
           
            
            //check if word it not boring, if not send request, if so just append the text to the view
            if (notBoring(lastitem)) {
                $.ajax({
                    type: "GET",
                    dataType: "json",
                    data: { "txt": lastitem },
                    url: source,
                    success: showGifs,
                    error: errorOnAjax

                });
            }
            else {
                var s = "<label>" + lastitem + "</label>";
                $('#giphy-append').append(" " + s);
            }

        }
        //function to check if the word is something we want to gif
        function notBoring(word)
        {

            var notBoringWords = ["cat", "lobster", "walking", "banana", "carrots", "running", "jumping", "dog", "moose", "apple", "walk" ];
            var notBoring = false;
            for (var i = 0; i < notBoringWords.length; i++) {
                if (word === notBoringWords[i]) {
                    notBoring = true;
                }
            }

            return notBoring;

        }

        //lets show the gif on the page
        function showGifs(data)
        {

            var emptystr = "";
            var giphyUrl = data.data.images.fixed_height_still.url;
            console.log(giphyUrl);

            emptystr += "<img src='" + giphyUrl + "' width=150px, height=150px/>";


            $('#giphy-append').append(emptystr);

        }

        //at button push the page reloads, or simply and ENTER key
        $('#reset').click(function () {
            location.reload();
        });

        //if there is an error on the request
        function errorOnAjax()
        { 
            console.log("error");
        }
    
    });
});