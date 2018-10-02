# Welcome to HW2

This is my second assignment for this class. For this assignement I needed to first understand branching in Git. My next objective was to learn and use Javascript, and the it's library jQuery. I created an HTML form, and by using Javascript, I was able to select and modify elements in the DOM and repond to events.

## Using Git (Part 2)

## Planning, planning, and more planning

1. Before I rushed and started coding, I decided to think on how the webpage should look, what kind of functionality the webpage would perform, and finally what the page would look after the form is submitted by the user. 

2. Once I decided on what to do, I started drawing out a layout for the page, and how it would look after the form submission


**Enter image here**

## Layout

1. Similar to the last assignment, I used Bootstrap and CSS for a consistent and clean look throughout the page

```bash
<div class="container" id="hidden-container">
  <div class="row justify-content-center">
    <div class="col-4"">
      <table id="input-table"></table>
    </div>

    <div class="col-4">
      <ul  id="summary"></ul>
    </div>
  </div>
  <br><br>
  <button type="submit" class="btn btn-primary btn-lg" id="return-btn">Back to Input Page</button>
</div>
```

```bash
#title {

	text-align: center;
	padding-top: 30px;
}

```

## Javascript and jQuery

1. Javascript is used in web pages, and it allows a certain action or "event" to occur based on the actions of the user. For this assignment, I used it to obtain user information from the form, and calculated the information and present the result to the page. 

2. For this this assignment, we were required to use the JavaScript library, jQuery. jQuery is a fast, small, and feature-rich JavaScript library. As we see in the code snippet below the $() defines and accesses jQuery and performs the actions to the elements.

3. First procedure was to add the link to my script file onto the HTML file (since I decided to do a seperate file for JavaScript).

```bash
<!-- Own Javascript -->
 <script type="text/javascript" src="script.js"></script>    
 ```

 4. I used the .ready() function to make sure that the page was properly loaded and ready for the user input, and nested my functions in there. 

 ```bash
  $(document).ready(function(){

  	//code omitted

  });
  ```

 5. For the form submittion and retrieving the information from the page, I used the .submit() function. This function allows the input information to be retreived once the user hits the button, and assigns the inputs to local variables in order to do some calculation with them. 
 
 ```bash
  $('#myForm').submit(function(e){
          e.preventDefault();

          //Takes in all the inputs from the form and assigns it so we can do some calculation with it
          var b_weight = $('#body-weight').val();
          var w_lifted = $('#weight-lifted').val();
          var rep = $('#repetition').val();

          });
 ```

6. With the variables that I grabbed from the user, I input the numbers in the formula that I retreived from the NCSA page which calculates the 1RM number.

```bash
var ans = w_lifted / (1.0278 - (0.0278 * rep));
var round = Math.ceil(ans);
```

7. After the numbers have been calculated, it shows it on the page. I used jQuery to modify and add to the DOM and display the result using the .append() function. The page shows what the user has input, the calculated numbers, and a word of advice. 

```bash
//Appends the user inputs
$('#input-table').append("<tr><th>Data Entered:</th></tr>");
$('#input-table').append("<tr><td>BodyWeight: " + b_weight + "lbs.</td></tr>");
$('#input-table').append("<tr><td>WeightLifted: " + w_lifted + "lbs.</td></tr>");
$('#input-table').append("<tr><td>Repetition: " + rep + "</td></tr>");
```

```bash
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
```

8. Last but not least was the usage of the show and hide method. Since I put both the form and the result in containers, it was easy for me to make either one disappear or show. After the form has been submitted, the form container is hidden, and the result container is shown.  

```bash
//Let's hide the form so we can make space to place result
$("#myForm").hide();

//This will show both the user input and the result that was calculated
$("#hidden-containter").show();
```

## Validation 

1. Since this was an user input form, I wanted to make sure that the code doesn't break if the user adds a faulty number. 

2. I made sure that I set a limit for all the unrealistic numbers that may be input by the user, by using min and max value.

```bash
<div class="form-group">
      <label for="repetition">Number of Repetition:</label>
      <input type="number" class="form-control" id="repetition" placeholder="Enter the Number of Repetition" min="1" max="15" required>
    </div>

```

## Working Page

(https://github.com/swakita14/swakita14.github.io/tree/master/HW2/working.PNG)

(https://github.com/swakita14/swakita14.github.io/tree/master/HW2/working1.PNG)