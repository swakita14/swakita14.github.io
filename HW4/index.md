# HW4

* [Demo Video](https://youtu.be/WKAEgg2KWg4)

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



## Simple Server-Side Dynamic page using HTTP POST

1. The next task at hand was to use the POST method and create a form that mixes hexidecimal colors and outputs the resulting color. 

2. As same as above, I decided to create the View first and add values such as "name" and "id" on each elements as I went

3. This second part required us to use Razor's HTML Helpers for all form input elements and the form itself. Not going to lie, this was challenging at first but you realize its easier to build 

```c#
@*This is the start of the input form that uses Razor Helper for the form and the input *@
        @using (Html.BeginForm("ColorChooser", "Color", FormMethod.Post, new { id = 0, @class = "myForm" }))
        {
            <div class="form-group">
                <label for="input-color1">First Color:</label>
                @Html.TextBox("color-input1", "", new { @class = "form-control", @pattern = "#[0-9A-Fa-f]{6}", @placeholder = "First Color", required = "required" })
            </div>
        }
```

4. Once I had to form created, I decided to move on to the Controller. Since the requirement was to create a new Controller..... thats what I did and named it "Color"

5. First I took the user input and assigned it to a local variable
```c#
 //takes the user input and assigns it to local variable
 color1 = Request.Form["color-input1"];
 color2 = Request.Form["color-input2"];
```

6. I then extraced the argb value out of the colors to do some addition with them to create the final color
```c#
 //changes hex to argb format to do some addition with it
 Color rgb_color1 = ColorTranslator.FromHtml(color1);
 Color rgb_color2 = ColorTranslator.FromHtml(color2);
 ```

 7. I then wrote a conditional statement that will add the values of the argb unless it was over 255, which then I set it to 255
```c#
 //color addition, if the value goes over 255, it gets set to 255 else addition happens
  if (rgb_color1.A + rgb_color2.A >= 255)
  {
    final_A = 255;
  }
  else
  {
   final_A = rgb_color1.A + rgb_color2.A;
   }
```

8. Then I coverted the argb value back to hex to show the color 
```c#
//converts the calculated argb value back to hex
string finale = ColorTranslator.ToHtml(Color.FromArgb(final_A, final_R, final_G, final_B));
```

9. Finally, I created the object and sent it back with the color as the background to the View
```c#
ViewBag.shape3 = "width:75px; height: 75px; border: 1px solid #000; background: " + finale + "; ";
```


## Git Merge 

1. As always after all the coding and testing is done on the branches, I merged it back to master

```bash
git merge color-chooser
```