$(document).ready(function () {
    $('#text-input').bind('keypress', function (e) {
        if (e.which === 32) {//space bar
            alert('space');
        }
      
    });
});