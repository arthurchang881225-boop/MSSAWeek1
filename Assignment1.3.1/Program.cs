//Write a program in C# to calculate area of triangle, square and rectangle. Write 3 different functions for each shape to take dimensions of figure and display the area. You may create menus.

bool continueProgram = true;
while (continueProgram)
{
    Console.WriteLine("Select a shape to calculate area:");
    Console.WriteLine("1. Triangle");
    Console.WriteLine("2. Square");
    Console.WriteLine("3. Rectangle");
    Console.WriteLine("4. Exit");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            // Calculate area of triangle
            Console.WriteLine("Enter the base of the triangle: ");
            int baseLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle: ");
            int height = int.Parse(Console.ReadLine());
            double triangleArea = 0.5 * baseLength * height;
            Console.WriteLine($"The area of the triangle is: {triangleArea}");
            break;
        case 2:
            // Calculate area of square
            Console.WriteLine("Enter the side length of the square: ");
            int sideLength = int.Parse(Console.ReadLine());
            double squareArea = sideLength * sideLength;
            Console.WriteLine($"The area of the square is: {squareArea}");
            break;
        case 3:
            // Calculate area of rectangle
            Console.WriteLine("Enter the length of the rectangle: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle: ");
            int width = int.Parse(Console.ReadLine());
            double rectangleArea = length * width;
            Console.WriteLine($"The area of the rectangle is: {rectangleArea}");
            break;
        case 4:
            continueProgram = false;
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;

    }

    if (continueProgram)
    {Console.WriteLine("Do you want to continue? (y/n)");
    string userInput = Console.ReadLine();
    if (userInput.ToLower() != "y")
    {
        continueProgram = false;
    }
    }
} 