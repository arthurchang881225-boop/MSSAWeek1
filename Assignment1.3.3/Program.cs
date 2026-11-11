/*Write a program in C# to read n number of values in an array and display it in reverse order.
Test Data :
Input the number of elements to store in the array :3
Input 3 number of elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 7
Expected Output:
The values store into the array are:
2 5 7
The values store into the array in reverse are :
7 5 2*/

Console.WriteLine("Input the number of elements to store in the array :");
int arrSize = int.Parse(Console.ReadLine());
int[] numbers = new int[arrSize];

Console.WriteLine($"Input {arrSize} number of elements in the array :");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"element - {i} : ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Expected Output:");
Console.WriteLine("The values store into the array are:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}

Console.WriteLine("\nThe values store into the array in reverse are:");
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write($"{numbers[i]} ");
}
/*foreach (int num in numbers.Reverse())
{
    Console.Write($"{num} ");
}*/