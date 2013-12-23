using System;

class CheckIfInCircle
{
    static void Main()
    {
        Console.Write("Input position X: ");
        double positionX = double.Parse(Console.ReadLine());
        Console.Write("Input position Y: ");
        double positionY = double.Parse(Console.ReadLine());
        
        //Get the distance from the point to the center of the circle (0, 0)
        double pointDistance = Math.Sqrt(Math.Pow(positionX, 2) + Math.Pow(positionY, 2));

        //Check if the distance from the point to the center of the circle is smaller than the radius
        bool result = pointDistance <= 5;
        Console.WriteLine(result ? "The point is within the circle" : "The point is out if the circle");
    }
}