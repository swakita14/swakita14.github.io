function showAstronauts(results) {
    console.log(results);
    $('#astronaut-tables').find('tbody').empty();


   
    $.each(JSON.parse(results), function (key, item) {


        console.log(item.Astronaut1.Country.CountryName);

        var astronaut = '<tr><td>' + item.Astronaut1.Name + '</td ><td>' + item.Astronaut1.Country.CountryName + '</td></tr>';
        $('#astronaut-tables').find('tbody').append(astronaut);




    });

    

}

function main() {

    console.log("loaded!");

    $("#selectList").on("change", function (e) {
        var text = this.value;
        /* Construct the AJAX call to retrieve the Bids for the item associated with the id */
        $.ajax({
            type: "GET",
            dataType: "json",
            url: "/AJAX/GetAstronauts",
            data: { "text": text },
            success: showAstronauts
        });

    });
}

/*Main method */
$(document).ready(main);