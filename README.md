# Order Tracker

#### By: Ryan Broadsword

#### Application that allows the user to keep track of vendors and their orders. Add new vendors and orders as well. 

## Technologies Used

* C#
* .Net 5
* REPL
* CSS
* HTML


## Description 

Use Razor to display information on each page.

Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.
The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.
Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.
Pierre should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new".

## Setup/Installation Requirements

### Clone project
* clone repository
* open in vs code
* open terminal
* in terminal run "dotnet build" to make sure everything is up to date.
* in terminal run "dotnet test" to see test results for functionality. 
* in termianl run "dotnet run" to run the program and follow the prompts given in the console. 
* select localhost:5000/ to launch application in browser. 


## Known Bugs

* CSS styles is not implementing. 
* Error CS1503 in Vendor.cs
* Error CS0029 in Vendor.cs


## License

Not currently licensed 

Copyright (c) July 16th 2022, by Ryan Broadsword rbroadsword@gmail.com 
