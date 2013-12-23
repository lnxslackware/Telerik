using System;

class CheckPoint
{
    static void Main()
    {
        Console.Write("Please enter position X: ");
        double positionX = double.Parse(Console.ReadLine());
        Console.Write("Please enter position Y: ");
        double positionY = double.Parse(Console.ReadLine());

        //check if point is within the circle
        bool inCircle = Math.Sqrt(Math.Pow((positionX - 1.0), 2) + Math.Pow((positionY - 1.0), 2)) <= 3;
        
        //check if point is within the rectangle
        bool inRectangle = ((positionX < 5) && (positionX > -1)) && (positionY < 1) && (positionY > -1);
        
        //displaying the result
        Console.WriteLine(inCircle ? "The Point is within the circle" : "The point is not in the circle");
        Console.WriteLine(inRectangle ? "The Point is within the rectangle" : "The point is not in the rectangle");
    }
}