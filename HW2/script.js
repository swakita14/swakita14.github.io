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


         

 


          });

});
