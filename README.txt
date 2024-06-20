﻿﻿2024-06-18
﻿Group Name: Pi Security
Course code:CYB206
Group Members: Matthew Gabrielle
			   Sameerkumar Barot
		       Vinay kumar Chepuri
2230
Web app create w/ VS2022 .NET'/
No auth........
SSL cert SH-1
Created README.txt
Ran the program, confiremed that web page open properly without any error.
we just go Views>Home>index.cshtml and change header welcome with "MvcMovies"
and ran program in 3 differnt browsers Chrome,Firefox and Ms edge.
URL:https://localhost:7256/

2240
Added controller
Completed part 2
after successfully ran part 1 and moving forward to Add controllers MvcMovies>Controllers>MvcMovies.cs

	//What is Controllers ?
		Classes that:
		Handle browser requests.
		Retrieve model data.
		Call view templates that return a response.
we Create new controller "MvcMovie.cs"
add namespace MvcMovie.controller
and we used public method in controller because it can handle incoming HTTP and HTTPS request.
we tried other method like Private and Projected that are not meant to handle HTTP requests. 
from online resources private and projected methods are used for internal logic and helper functions.

we Created two public string "Index" and "welcome"
and make sure confirm again 

2250 
Now we tried to modify a code and pass some parameter information from the URl
we created Public string Welcome and add 2 parameters
string "name"
integer "numTimes"
and this time i used HtmlEncoder to encode protentially dangerous characters in user input,
avoid XSS attacks and Java code injections.

2255 (	we just started Part 3 that edit views part.)
Added view
Right-click on the Views folder, and then Add > New Folder and name the folder
ight-click on the Views/MvcMovies folder, and then Add > New Item.
Views/Shared/_Layout.cshtml
Open the Views/Shared/_Layout.cshtml file.
In the Add New Item - Furnitures dialog:
	we tried to change layout of web page
	add header "h2"
	create _Layout.cshtml


2330
Added model
We created a class named Furniture.ca and added it to the models folder during this task. 
In order to add the Furniture type, price, rating, and ratings, we also updated the code. 
Next, we updated the controller drawer controller.cs file with the newly scaffolded item, 
which allowed us to add the NuGet packages. 
Ultimately, we added the migration initialCreate by going to the NuGet package manager> package manager console. 
We will test the application once the database has been created and updated, 
and we will look over each code once we have the required output from 
the automatic code that was generated during the migration process.


>First Move
I navigated to Tools > NuGet Package Manager > Package Manager Console to open the Package Manager Console (PMC).
Launch the application.

Migration file: SpringPIContextModelSnapshot.cs
Migration file: 20240620121239_InitialCreate.cs


2024-06-19
1150
Created database

We started this task by using the SQL Server Object Explorer to look over the database. 
This made it possible for us to obtain the table we had built in the earlier phase, which included details about the different kinds of Mattress, the cost, the rating, and the reviews. Next, we created a new class in the models folder and named it SeedData. 
Next, we looked over and made some changes to include drawer information on the output webpage. 
After making the necessary adjustments to the program.cs file, we were able to obtain the desired output. 

1230
	we tried to Add search option.
	try to solve error other 2 team members cannot see database.
	we are trying to solve the issue

1400
We have uploaded images as backgroud for our application
got some errors while uploading images 
Finally uploaded the images for our application

1420
We also added a link in our About Us to tell about our application
we included a image and a logo in our About Us
