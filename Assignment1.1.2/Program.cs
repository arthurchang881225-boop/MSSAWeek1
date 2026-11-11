//Write a C# program to print the sum of two numbers. Get the input from user.

Console.WriteLine("Please enter the first numbers to add:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter the second number to add:");
int num2 = int.Parse(Console.ReadLine());

int sum = num1 + num2;

Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");