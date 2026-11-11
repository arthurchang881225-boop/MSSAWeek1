//Create a console application in C# to store and print personal details of a person like name, age and address on console screen. Make use of appropriate variables.

Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

Console.WriteLine("Please enter your age:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter your address:");
string address = Console.ReadLine();

Console.WriteLine($"Your name is {name}, you are {age} years old, and you live at {address}.");  