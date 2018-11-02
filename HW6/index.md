# HW6

* [Demo Video](https://youtu.be/i8jkJDDin_c)

## Preparation 

1. This week, since we were going to be working on an existing database, I downloaded and installed SQL Sever Manager to restore the .bak database file.
2. After I restored the database and connected to it, I added the ADO data modeler to my Visual Studio project and added all the models necessary for it.


## Feature #1 People Search

1. Our goal in this first feature was to create a search function and make it look through the db and returning it the person, and its information. 
2. To get a good grip on the code itself and the searching function, I created a scaffold controller using the dbContext and the Person class.
3. I went to my View, and using the Person model, I created a simple search bar that would look through all the person in my db and output the results like a button to click on 

```html

```

4. Then I went to my Controller, and added some methods that would get the ```queryString``` from the input form and use that to look through the db.

```c#


```

5. From part of the scaffold code from the Details Action method, I was able to gain the basic concept and information on how the code worked, and of course I rewrote the details because who likes the scaffold code look?

```c#


```

6. I also added a photo place holder for the person as well.


## Feature #2 Customer Sales Dashboard

1. This part was a extended add-on to the Feature #1. So the stakeholders could find out if the person is a customer, then show some details about their company and the World Wide Importer's sales to it. 

2. So I wrote a LINQ query that would find out if the person that is searched for is the primary contact person (that their PrimaryContactPersonID in Customer is the ID)

```c#


```

3. If that person was, I assigned my ViewModel Customer a Customer from the dbContext with that ID.
4. Then I was able to access the Customer objects information from there. 

```html


```

5. Finally for the Purchases, I used to ViewBags that I assigned values for using a LINQ statement. This showed the count of the order and the total gross sales and profit that they have made from this customer.

```html


```

6. Finally I added the top 10 most profitable items the customer has purchased 


