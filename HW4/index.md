# This is the README for HW4

## Preparation

1. First step was to create an empty ASP.NET MVC5 web app, and set the design to MVC
2. I decided to delete the Model Folder because I knew we weren't going to use it due to the lack of dB in this assignment
3. Before I went away ahead in coding, I organized and planned how I was going to tackle this two-step process in the HW. 
4. I came to the conclusion that I would build the View(making sure to add id's and name's so I could use it in the Controller), and then I would build the Controller up



## Simple Server-Side Dynamic page using HTTP GET

1. This assignment was to create a "Miles to MEtric Converter" page using the HTTP GET
2. I used one user input and 4 radio buttons(for the metric units)
3. I then added some client side validation on the form input in order to assure that it had to be input before the form was processed, and that only numbers were allowed to be input
```html
<label for="miles-input">Miles:</label>
    <!--This takes in the user input for miles-->
    <input type="number" class="form-control" name="miles" id="miles-input" placeholder="Enter Miles" required>
```
4. I then added some radio buttons for the metric units
```html
<input class="form-check-input" type="radio" name="metric-unit-radio" id="mm" value="mm" checked >
    <label class="form-check-label" for="mm1">
```
5. And now I was ready to hop on the controller and start coding some calculations and functionality 

6. First I grabbed the value of the user input and the radio button value that was selected 

```c#
 //Takes in user input miles
double miles = Convert.ToInt32(Request.QueryString["miles"]);

 //this recognizes the value of the radio button that the user has selected, in order to see which unit we are converting to
string metricUnit = Request.QueryString["metric-unit-radio"];

```

7. Then by using conditional statements, I was able to multipy the correct numbers of the specific metric unit selected. Then I switched my boolean variable to true to make the result show up on the bottom of the page 

```c#
 if (metricUnit == "mm")
        {
            unit = "mm";
            milesToMetric = (miles * 1609344);
            ViewBag.Show = true
        }
```

8. This is the resulting string that shows up
```c#
 //output the results of the convertion
ViewData["results"] = (miles + " miles is equal to " + milesToMetric + unit);
```


## Demo Video
[Video](https://youtu.be/WKAEgg2KWg4)