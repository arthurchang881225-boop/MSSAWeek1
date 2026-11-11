//Write a C# program to print the result of dividing two numbers. Print the quotient and remainder as well. Get the input from the user.

Console.WriteLine("Please enter the first number to divide:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter the second number to divide by:");
int num2 = int.Parse(Console.ReadLine());

int quotient = num1 / num2;
int remainder = num1 % num2;

Console.WriteLine($"The quotient of {num1} divided by {num2} is {quotient} with a remainder of {remainder}.");