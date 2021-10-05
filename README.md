# Test2_Nur
Week 2 Assignment

**ConsoleApp1 = Question 1

1)	This C# Program Displays Cost of a Rectangle Plot Using Inheritance.
-	The program should take one input from user cost for sq. foot during start of the application
-	Once the execution start it asks the user to input the length and breadth of the rectangle in an infinite loop and displays the final cost. User can press q to quit the application
-	The program should have a rectangle class to store the dimension, a Land Calculator class to store the cost for sq. feet and final cost. 

2)	Write a C# program which has a class called Line which has following characteristics (start point and end point). 
-	Each point is defined by a structure coordinate in a x-y plane (x is the x coordinate and y are the y coordinate). 
-	The class should provide two methods Display () which shows the starting and end point of the line and the slope ()- which displays the slope of the line.  


**Question 1 = Question 3

3)	Write a C# program with 3 classes which represent different travel classes (First class, second class and third class). 
-	Each classes implements the same interface which has a property about the cost per kilometre, a method to calculate the total cost given the distance of travel. 
A user will be asked to enter the distance of travel and upon entering the value he will be asked to select the class of travel (First/Second/Third) depending on his answer the final cost of his journey will be calculated.  



4)	Write a sample C# program for Processing fee calculator
-	A customer can make a purchase in one of 3 ways (credit card/ debit card/ bank transfer)
-	Each different type of payments is represented by an enumeration
-	Each type of payment methods has predefined processing fee percentage of 2.2%, 1.3%, 0.75% respectively. 
-	Each type of payment methods is represented by an interface which has following properties processing fee, purchase price and final price which cannot be changed outside of the class. (all 3 interfaces have same property names and functions)
-	Final class payment gateway implements all the 3 interfaces and have a display method which shows the breakdown of the price.
The final output is a user makes a purchase and asked to enter the price of the product.
In second step he must select the mode of payment and a final breakdown cost is displayed.  


**Question 5 = Question 5

5)	Write program which has a defined class and has a method with following signature 
object ManipulateObj(object obj)
The method behaves in following way
-	If we call “ManipulateObj” with a string type it will return the reverse of the string.
-	If we call “ManipulateObj” with an integer it will return the square of the integer
-	If we call “ManipulateObj” with a double it will return the decimal part of it.
-	If we call “ManipulateObj” with a bool it will return the inverse of the variable.
Finally, all the return value from the method should be converted to their native type and stored.
The final program should ask user to enter a value and the user input is passed to the method the output is printed with the “type” information. 


6) Write a C# program with following construct
-	An interface which defines “Speed”, “Engine capacity”, “Torque” and a method ShowBikeInformation()
-	A Benelli Bike class which implements the interface and provide read-only the basic values for each field.
-	An enumeration which includes following values “LedLight”, “ABS”, “USD Suspension”, “Launch Control”, “Cruise Control”, “Traction Control”
-	Another interface which defines List<string> SpecialFeatures(explanation for each type in the enumeration) and an indexer which returns a particular safety feature explanation when we pass the respective enumeration value
-	A Benelli Roadster series which inherits from Benelli Bike class and implements the second interface. However, it has updated specs compared to its base class (20% increment to all base values). 
-	A final Benelli Special Edition Roadster Series Bike which cannot be inherited further and has an updated spec from its base class (5% more values compared to Benelli Roadster. Additionally, It has an updated explanation for SpecialFeatures compared to its base class.

The output program asks the user to select one of the vehicle types and displays the vehicle characteristics. Additionally, it also displays the list of special features it has (if any) and asks user to select a special feature to get more information about it.   

