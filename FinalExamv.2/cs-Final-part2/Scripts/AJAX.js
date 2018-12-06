function showAstronauts(results) {

    $('#astronaut-tables').find('tbody').empty();
 
    $.each(JSON.parse(results), function (key, item) {

        var astronaut = '<tr><td>' + item.Astronaut1.Name + '</td ><td>' + item.Astronaut1.Country.CountryName + '</td></tr>';
        $('#astronaut-tables').find('tbody').append(astronaut);

    });

}

function main() {

    console.log("loaded!");

    $("#selectList").on("change", function (e) {
        var id = this.value;
        /* Construct the AJAX call to retrieve the Bids for the item associated with the id */
        $.ajax({
            type: "GET",
            dataType: "json",
            url: "/AJAX/GetAstronauts",
            data: { "id": id },
            success: showAstronauts
        });

    });
}

/*Main method */
$(document).ready(main);