function spaceHit() {
    $('#people-search').bind('keypress', function (e) {

        //user hit a space bar
        if (e.which === 32) {
            giphySearch();
            e.preventDefault;
        }

        //What to do when the space bar is pressed 
        function giphySearch() {
            //gets the value of the user input
            var txt = $('#people-search').val();
            //get ths last item that is typed 
            var lastitem = txt.split(" ").pop();

            


            //routing it to my custome controller to send request 
            var source = "AJAX/Search/" + txt; //Source


            //check if word it not boring, if not send request, if so just append the text to the view
          
                $.ajax({
                    type: "GET",
                    dataType: "json",
                    data: { "name": lastitem },
                    url: source,
                    success: showResult,
                    error: errorOnAjax

                });
            
          
            
        }
    });
}


function showResult(data) {
    console.log(data);
}

function errorOnAjax() {
    console.log("Error on AJAX");
}


function main() {

    alert("loaded!");
    spaceHit();
}

/*Main method */
$(document).ready(main);