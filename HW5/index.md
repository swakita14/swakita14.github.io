# HW5

* [Demo Video](https://www.youtube.com/watch?v=v9qrLMEKo9g&t=20s)

## Preparation

1. Similar to the previous homework, I created a MVC project and initialized all my files
2. I saw the form that he wanted us to submit and the looks of it, so I carefully planned out everything concerning the columns and the boostrap grids

## Creating a Simple One-Table LocalDB and Populating it using T-SQL

1. Great thing about Visual Studio is that when you install the data storage and procesing workload when installing VS, it gives you an option to be able to add a localdB to your project as well.
2. After adding the localdB to my project, I ran a query on it to make sure the tables were named and created. 

```sql




```

3. I also wrote out a query that would drop the entire table and clear things out.

```sql


```

4. Last but not least, I created a query that would insert values into the table, which would eventually show up on the page when I call the list. 

```sql

```

## Model Class and Building a Strongly Typed View that Uses it

1. Model class in this project represents and object carrying data. Since we wanted to create stronly typed views, instead of just returning Views with no parameters, we placed and threw back the View with the model inside the parameter.
2. This is a little snippet of my model class. As you can see I have declared the label names for the model, and if they are required or not, and the validation message that follows it if not entered correctly. 

```c#

```
## Entity Framework Context

1. In order to have the Entity Framework in your project, you first need to user NuGet to find and install the package. 
2. This context class was placed in the DAL (Data Access Layer) and it functioned as the connecting bridge between the classes in the project with the database. 
3. As you can see in the method, you place the localdB name in the parameter and connect to it with the connection string

```c#

```
4. If you go to the database and click property it should give you the connection string and you just copy and paste it in the Web.config file to tie the database to the project 

```html


```


## Designing the View

1. For this I struggled a bit due to the fact that the text areas for the views were not adjusting the way I wanted it to. 
2. The solution I found was to first open the Inspector on my web browser, and check the element, add the css ```max-width``` element to it and then change the column for the div element class. 




