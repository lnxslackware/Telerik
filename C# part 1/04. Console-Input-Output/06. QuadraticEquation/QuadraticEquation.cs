using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Please enter coefficient \"a\": ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter coefficient \"b\": ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter coefficient \"c\": ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = Math.Pow(b, 2) - (4 * a * c);

        if (discriminant < 0)
        {
            Console.WriteLine("The quadratic equation has no real roots.");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("The quadratic equation has one double real root:");
            Console.WriteLine(-b / (2 * a));
        }
        else
        {
            Console.WriteLine("The quadratic equation has two real roots:");
            Console.WriteLine((-b + Math.Sqrt(discriminant)) / 2 * a);
            Console.WriteLine((-b - Math.Sqrt(discriminant)) / 2 * a);
        }
    }
}