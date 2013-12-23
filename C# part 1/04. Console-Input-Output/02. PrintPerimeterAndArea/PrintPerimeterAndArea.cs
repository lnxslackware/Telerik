using System;

class PrintPerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter the circle's radius: ");
        double circleRadius = double.Parse(Console.ReadLine());

        double circleArea = Math.PI * Math.Pow(circleRadius, 2);
        double circlePerimeter = 2 * Math.PI * circleRadius;

        Console.WriteLine("The Area of the circle with radius = \"{0}\" is \"{1}\"", circleRadius, circleArea);
        Console.WriteLine("Its perimeter is \"{0}\"", circlePerimeter);
    }
}