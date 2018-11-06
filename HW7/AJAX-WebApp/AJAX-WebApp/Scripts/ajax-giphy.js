$(document).ready(function () {
    $('#text-input').bind('keypress', function (e) {

        //user hit a space bar
        if (e.which === 32) {
            giphySearch();
            e.preventDefault;
        }

        function giphySearch() {

            var txt = $('#text-input').val();
            var lastitem = txt.split(" ").pop();

            if (e.which === 32) {
                var source = "AJAX/Sticker?q=" + txt; //Source
            }
            
            //alert(urls);
            if (notBoring(lastitem)) {
                $.ajax({
                    type: "GET",
                    dataType: "json",
                    data: { "txt": lastitem },
                    url: source,
                    success: showGifs

                });
            }
            else {
                $('#giphy-append').append('<div class="col-sm-2"><h3>' + lastitem + '</h3 ></div>');
            }

        }

        function notBoring(word) {

            var notBoringWords = ["cat", "lobster", "walking"];
            var notBoring = false;
            for (var i = 0; i < notBoringWords.length; i++) {
                if (word === notBoringWords[i]) {
                    notBoring = true;
                }
            }

            return notBoring;

        }

        function showGifs(data) {

            //$('#giphy-append').attr('src', data.data.images.fixed_height_still.url);

            //$('#giphy-append').append('<img>' + $(gif).attr('src', data.data.images.fixed_height_still.url) + '</img>');

        }

        $('#reset').click(function () {
            location.reload();
        });
    
    });
});