/*Create a structure named “Point” and 2 data members: X and Y coordinate. Declare 2 points: P1 and P2. Determine if P2 is to the right or left of P1 or on same axis , by comparing the x xoordinates. ( if p1.x is more than p2.x , it is to the right )*/

using System;

struct Point
{
    public double xCoord;
    public double yCoord;
}

class Program
{
    static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point();

        p1.xCoord = 3.0;
        p1.yCoord = 1.5;
        
        p2.xCoord = 1.0;
        p2.yCoord = 2.0;

        if (p1.xCoord > p2.xCoord)
        {
            Console.WriteLine("P2 is to the left of P1");
        }
        else if (p1.xCoord < p2.xCoord)
        {
            Console.WriteLine("P2 is to the right of P1");
        }
        else
        {
            Console.WriteLine("P2 is on the same axis as P1");
        }
    }
}