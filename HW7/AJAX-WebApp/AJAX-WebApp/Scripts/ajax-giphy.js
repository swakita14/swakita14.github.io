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
            var urls = "TranslateApi/Sticker?q=" + txt;

            alert(txt);

            $.ajax({
                dataType: "json",
                url: urls,
                data: data,
                success: success

            });






        }





      
    });
});