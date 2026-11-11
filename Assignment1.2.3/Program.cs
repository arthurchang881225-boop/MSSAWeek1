/* Write a menu driven application to perform calculation functions like addition, subtraction, multiplication, and division. Call them appropriately when user selects the option. Give the user the option to continue or exit the program.
*/

bool continueProgram = true;
while (continueProgram)
{
    Console.WriteLine("Enter the first number: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the second number: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Select an operation to perform:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            // Perform addition
            Console.WriteLine($"The sum is: {num1 + num2}");
            break;
        case 2:
            // Perform subtraction
            Console.WriteLine($"The difference is: {num1 - num2}");
            break;
        case 3:
            // Perform multiplication
            Console.WriteLine($"The product is: {num1 * num2}");
            break;
        case 4:
            // Perform division
            if (num2 != 0)
            {
                Console.WriteLine($"The quotient is: {num1 / num2}");
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }

    Console.WriteLine("Do you want to continue? (y/n)");
    string userInput = Console.ReadLine();
    if (userInput.ToLower() != "y")
    {
        continueProgram = false;
    }
}
/*
Console.WriteLine("Enter the first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Select an operation to perform:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");

int choice = int.Parse(Console.ReadLine());

switch (choice)
{
  case 1:
    // Perform addition
    Console.WriteLine($"The sum is: {num1 + num2}");
    break;
  case 2:
    // Perform subtraction
    Console.WriteLine($"The difference is: {num1 - num2}");
    break;
  case 3:
    // Perform multiplication
    Console.WriteLine($"The product is: {num1 * num2}");
    break;
  case 4:
    // Perform division
    if (num2 != 0)
    {
        Console.WriteLine($"The quotient is: {num1 / num2}");
    }
    else
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
    break;
  default:
    Console.WriteLine("Invalid choice.");
    break;
}*/