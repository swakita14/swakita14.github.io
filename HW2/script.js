//Makes sure that the page is ready and loaded properly
 $(document).ready(function(){


 		//Just a test message to see if everything ran correctly
        console.log("Loaded Successfully");

        //Hides the return to original page button
        $('#return-btn').hide();

        //Form submission function
        $('#myForm').submit(function(e){
          e.preventDefault();

          //Takes in all the inputs from the form and assigns it so we can do some calculation with it
          var b_weight = $('#body-weight').val();
          var w_lifted = $('#weight-lifted').val();
          var rep = $('#repetition').val();


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

          //Based off of the calculation, it will give you your 1RM and a word of advice
          if(round < b_weight){
          	$('#summary').append("<li>You are a beginner and your estimated max is: " + round + "lbs.</li>");
          	$('#summary').append("<li>You are still at a position where linear progression would be work the best, make sure to increase the workload every traning session.</li>");
          }
          else if(round > b_weight && round < (b_weight*2) ){
          	$('#summary').append("<li>You are an intermediate lifter and your estimated max is: " + round + "lbs.</li>");
          	$('#summary').append("<li>At this level, linear progression becomes tough, its time to move on to proper programming.</li>");
          }
          else {
          	$('#summary').append("<li>You are an advanced lifter and your estimated max is: " + round  + 'lbs.</li>');
          	$('#summary').append("<li>Make sure to focus on the three main movements (bench, deadlift, squat), and keep the accessory movements minimal.</li>");
          }

          //Allows users to return to the original input form pages
          $('#return-btn').show();
          $('#return-btn').click(function() {

          	location.reload();
          });

         

 


          });

});
