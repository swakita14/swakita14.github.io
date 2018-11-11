# HW7

* [Demo Video](https://www.youtube.com/watch?v=gTv8FzgwHOo)

## Planning / Setup

1. First things first, we signed up for an API key at Giphy in order to access their data. 
2. As we have the API key in our hands, it is important to hide the API key instead of pasting it directly in either our js or controller. 

```c#


```

3. The reason why we use the controller instead of just the js file and the View is because the js file gets sent to the page and is visible to the users, and we don't want the users seeing everything happening and how its happening. 
4. The next step is to connect the custom js file that we are using and the View with a razor with an ```@section``` tag and adding the path to our js file

```html


```

5. Once we got that working and communicating with one another, its time to work with the request sending and parsing through the data that we receive from Giphy.


## Action 

1. First I grabbed the user input string, and sent it to the controller, and the controller returns the JSON data and we use Javascript to parse through the data and grab the specific url that we want to use to output to our page. 

Create url to send:
```js

```

Send the request and get JSON data back and return it to the js file:

```c#

```

Parse through it and grab the specific data that we want to output 

```js

```

## Custom Routing 

1. In our ```routes.config``` file, the specific routes are listed, and which paramter takes in what, and finally when the items are not listed in the url, which url to default to. 

2. I added my own custom routing to the file, which leads takes the searching string to the controller and the action method that creates the request and receives the response 

```html

```


## Database Logging 

1. One of the requirements for this HW was to save the information of the user including the IP address, the browser, the time the request was sent, and the search string or the request. So I created the database, made a model file, and added the context file just like the other projects. 

Creating dB query:

```sql


```
Query to drop table:

```sql


```

Model file:

```c#

```

Context file so that the controller can interact with the dB

```c#


```

2. Then I initialized the context variable and started assigning the necessary information using the ```Request``` function which is part of the controller. 

```c#


```

## Working Pages 