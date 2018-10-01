# Welcome to HW1

This is my first homework assignment for my CS460 class. The task assigned to us was to use create a web-page using HTML, and using Bootstrap and CSS to make the page look neat and organized. 

## Using Git

One of the first requirements is that we familiarize with Git. I knew that that this class would require to use Git extensively so I went ahead started using Git over the summer. 

1. First things first, I set the user name and the email that will be attached to my commit transactions

```bash
git config --global user.name "swakita14"
git config --global user.email "swakita14@wou.edu"
```

2. I had already created a repository in Git so I cloned the respository. 

```bash
git clone https://github.com/swakita14/swakita14.github.io
```

3. I intialized git, and added the folder where all my HW1 files to be in, checked the files to be added, added the files, committed it, and pushed it to my remote reposititory.

```bash
git init
git status
git add .
git commit -m "Initial Commit"
git push -u origin master
```

## Multi-page, Hyperlinked Pages

The next requirement I decided to tackle was the multi-page, hyperlink requirement. Since I decided to create a Fitness page, I decided to add a welcome introduction, program, and a article page. 

1. I added the links to the navbar so that the user can access and navigate to the page that they wish to proceed to. I did this for each page so that the users can switch to different pages back and forth

```bash
<ul class="navbar-nav">
        <li class="navbar-item"><a class="nav-link" href="index.html">Home</a></li>
        <li class="navbar-item"><a class="nav-link" href="page3.html">Program Information</a></li>
        <li class="navbar-item"><a class="nav-link" href="page2.html">Articles</a></li>
</ul>
```

2. Since I added an Article page for the users that are wanting to more about the program, I added the author, the title, and the publication date to each listed article and added hyperlinks each of the article listed. 

```bash
	<tr>	 
	 <td>Steven J. Fleck</td>
      <td><a href = "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC3588896/">Non-Linear Periodization for General Fitness & Athletes</a></td>
      <td>September 2011</a></td>
    </tr>
    
```

## Uses Bootstrap - Single/Multicolumn Pages

My first question question was: What is Bootstrap?! So I decided to take it to the web and found out that it is a "front-end framework for designing websites and web applications" 

1. First step for me was to add the Bootstrap CDN to my HTML page so I could access the functionality and the library of Bootstrap. I also added other libraries to the page. 

```bash
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
      
      <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

      <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>

      <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>

```

2. I then added a mutlicolumn look to my page with the different types of categories of weight lifters

```bash
<div class="container">
  <div class="row">
    <div class="col">
      <dl>
      <dt>Beginner:</dt>
      <br>
      <dd >Program includes numerous accessory exercise to focus on mind-muscle connection. Major goal is to build a strong and stable foundation for future muscle development
      </dd>
    </div>
    <div class="col">
     <dt>Intermediate:</dt>
     <br>
     <dd>Implements less acessory than beginner program. Includes heavier and more repeptition of the main three lifts</dd>
    </div>
    <div class="col">
      <dt>Advanced:</dt>
      <br>
      <dd>Contains little to none accessory movements. Program is based upon 75% to 80% of max weight. Takes severe toll on body if not coditioned well.</dd>
    </div>
  </dl>
  </div>
</div>
```

3. Then I decided to go ahead to my main welcoming page and add a single column

```bash
<div class="container">
  <div class="row">
    <div class="col-6">
      <p id="quote">"Functional fitness is about preparing you for life, rather than something specific like a big race or a lifting competition. Think anything from squatting down to pick something off of the floor, to turning and reaching for the oatmeal on a high shelf. This type of exercise mimics your everyday actions while engaging multiple muscle groups."</p>
      <p id="quote">-Women's Health Magazine</p>
    </div>
  </div>
</div>
```

## Using CSS 

CSS is a great way to change the regular html elements and add different features. I used it mostly to add consistent padding thoughout the pages.

1. I added the css style page link to my HTML page to use my own stylesheet

```bash
<link rel="stylesheet" href="style.css" type="text/css">
```

2. I added some padding to my paragraph element with a summary id, and changed color, font, and text size for the quote I added to the welcome page. 

```bash
#quote {
	font-style: oblique;
	font-size: 20px;
	padding-left: 30px;
	color: grey;
}

#summary {
	padding-left: 30px;
}
```

## Adding Navbar with Table/Lists

Although I touched on this a bit on the hyperlink section above, I'll just add a bit more code snippit so it would be clear to see. I also used the Bootstrap navbar and made it simple in color and easy to navigate through.

1. Using Bootstrap, it allows my page to fit to size, and when the window is small, it only shows the main navbar item, which would redirect the user back to the homepage.

```bash
<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
  <a class="navbar-brand" href="index.html">Personal Training</a>
  <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
      <ul class="navbar-nav">
        <li class="navbar-item"><a class="nav-link" href="index.html">Home</a></li>
        <li class="navbar-item"><a class="nav-link" href="page3.html">Program Information</a></li>
        <li class="navbar-item"><a class="nav-link" href="page2.html">Articles</a></li>
      </ul>  
  </div>
</nav>
```

2. Another requirement of the lists was to use two types of list, so I decided to use the unordered list, `<ul` element for the navbar and I added some ordered list, `<ol>` elements for one of my pages

```bash
 		<ol>
          <li>Muscular Conditioning</li>
          <li>Hypertrophy</li>
          <li>Linear Max</li>
        </ol>
```







