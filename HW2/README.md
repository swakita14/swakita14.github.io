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

## Validation 