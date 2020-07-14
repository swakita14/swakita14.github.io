
$(document).ready(function(){

  // Making file name a global variable
  var fileName = ""

  // Async method to show uploaded file name 
  $(".custom-file-input").on("change", function() {
    fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
  });

    // Get the input from the UI, parse action happens on change 
    var input = document.querySelector('input[type="file"]');
    input.addEventListener('change', function(e){
    const reader = new FileReader()

    // Reader has finished loading and reading the file //
    reader.onload = function(e){
      
      // Assigning content result
      var content = reader.result;
      
      // Split the variables up by commas 
      var lines = content.split("\r")

      // Initialize line content variable 
      var lineContent = "";

      // Iterate through each line
      for (var count = 0; count < lines.length; count ++){

        // First row is the table so use it as is 
        if(count == 0){
          lineContent +="INSERT INTO dbo." + fileName.split('.').slice(0,-1).join('.') + "("

          var tableName = lines[0].split(",")
  
          for (var i = 0; i < tableName.length; i ++){
            lineContent += tableName[i] + ",";
          }

          lineContent = lineContent.slice(0, -1)
  
          lineContent += ") VALUES"
        }

        // Second Row on is the actual values 
        if(count > 0){

        // Add the starting parenthesis
        lineContent += "("

        // Access each item 
        var column = lines[count].split(",");   
        
        // Add each item to the varaible with proper formmatting 
        for (var i = 0; i < column.length; i ++){
          lineContent += "'" + column[i] + "',";
        }

        // Removing uncessary quotation marks 
        lineContent = lineContent.slice(0, -1);

        // Closing the line
        lineContent += "),"
        }    
      }

      // Remove last data since it was blank
      lineContent = lineContent.slice(0, -7);
      lineContent +=";"

      // Here for testing purpose
      //console.log(lineContent);

      //Automatically download the file 
      download(lineContent, fileName.split('.').slice(0,-1).join('.') + ".sql" , "text/plain" );

    }

    // Read text.... Is it necessary?
    reader.readAsText(input.files[0])



  }, false)

  

});