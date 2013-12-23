using System;

class FindTrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter side \"a\" in cm: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side \"b\": in cm");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter height \"h\" in cm:");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine("The area of the trapezoid is {0} square centimeters", area);
    }
}