
$(document).ready(function(){
  
    var input = document.querySelector('input[type="file"]');
    input.addEventListener('change', function(e){
    const reader = new FileReader()

    /** Reader has finished loading and reading the file  */
    reader.onload = function(){
      console.log(reader.result);
    }
    reader.readAsText(input.files[0])

  }, false)
});