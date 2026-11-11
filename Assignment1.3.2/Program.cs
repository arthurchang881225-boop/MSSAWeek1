//Write a console application in C# to explore different ways in which array is declared and initialized and explore different properties and methods of Array class.

// Create an array of four elements, and add values later
//string[] cars = new string[4];

// Create an array of four elements and add values right away 
//string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements without specifying the size 
//string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

//clear items in the array
/*Array.Clear(cars, 1, 2);
foreach (string car in cars)
{
    Console.WriteLine(car);
}*/

//get index of an element in the array
int index = Array.IndexOf(cars, "Ford");
Console.WriteLine($"Index of Ford: {index}");

//Accessing the array element using indedx
//Console.WriteLine($"Element at index 2: {cars[2]}");

