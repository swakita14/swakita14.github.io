//Makes sure that the page is ready and loaded properly
 $(document).ready(function(){


 		//Just a test message to see if everything ran correctly
        console.log("Loaded Successfully");

        //Form submission function
        $('#myForm').submit(function(e){
          e.preventDefault();

          //Takes in all the inputs from the form and assigns it so we can do some calculation with it
          var b_weight = $('#body-weight').val();
          var w_lifted = $('#weight-lifted').val();
          var rep = $('#repetition').val();

           //checking the form to make sure no large, obnoxious numbers are input in the form
          if (b_weight.length > 3 || w_lifted.length > 3) {
          	alert("Please enter a 3 digit value for both body weight and weight lifted");
          	return false;
          }

          if (rep.length > 2 || rep > 15){
          	alert("Please enter a value that is in the double digit or lift a heavier weight, Max: 15");
          	return false;
          }

           //Magic Formula by NSCA to calculate !RM
          var ans = w_lifted / (1.0278 - (0.0278 * rep));
          var round = Math.ceil(ans);

          //Let's hide the form so we can make space to place result
          $("#myForm").hide();
          
          //This will show both the user input and the result that was calculated
          $("#hidden-containter").show();

           //Appends the use inputs
          $('#input-table').append("<tr><th>Data Entered:</th></tr>");
          $('#input-table').append("<tr><td>BodyWeight: " + b_weight + "lbs.</td></tr>");
          $('#input-table').append("<tr><td>WeightLifted: " + w_lifted + "lbs.</td></tr>");
          $('#input-table').append("<tr><td>Repetition: " + rep + "</td></tr>");

         

 


          });

});
