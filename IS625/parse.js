
$(document).ready(function(){
  
    var input = document.querySelector('input[type="file"]');
    input.addEventListener('change', function(e){
    const reader = new FileReader()

    /** Reader has finished loading and reading the file  */
    reader.onload = function(){

      /** Processing and parsing CSV file */
      const lines = reader.result.split('\n').map(function (line){
        return line.split(',')
      })

      console.log(lines);
    }
    reader.readAsText(input.files[0])

  }, false)
});