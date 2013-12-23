using System;

class CalculateRectangleArea
{
    static void Main()
    {
        Console.Write("Please enter the rectagle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Please enter the rectangle's height: ");
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        Console.WriteLine("The area of the rectangle is: " + area);
    }
}