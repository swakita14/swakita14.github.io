$(document).ready(function () {
    $('#text-input').bind('keypress', function (e) {

        //user hit a space bar
        if (e.which === 32) {
            giphySearch();
            e.preventDefault;
        }

        function giphySearch(){

            //alert("Hello World");

            var txt = $('#text-input').val();
            //var lastitem = txt.split(" ").pop();
            var apiKey = "nlFMJaljRdG7yYkuQ2DvUspGg6Ti5qkj";
            var getURL = "https://api.giphy.com/v1/stickers/translate?api_key=" + apiKey + "&s=" + txt;

            //alert(urls);

            $.ajax({
                type: "GET",
                dataType: "json",
                url: getURL,
                success: showGifs

            });

        }

        function showGifs(data) {

            
            

            $("#giphy-place").attr('src', data.data.images.fixed_height_still.url);
            



        }





      
    });
});