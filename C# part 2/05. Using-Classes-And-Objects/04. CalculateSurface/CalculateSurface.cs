/*
 * Write methods that calculate the surface of a triangle by given: 
 * * Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
 */

using System;

class CalculateSurface
{
    static double SurfaceBySideAndAltitude(double side, double altitude)
    {
        return (side * altitude) / 2;
    }

    static double SurfaceByThreeSides(double sideA, double sideB, double sideC)
    {
        double p = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }

    static double SurfaceByTwoSidesAndAngle(double sideA, double sideB, double angle)
    {
        return (sideA * sideB * Math.Sin(angle)) / 2;
    }

    static void Main()
    {
        Console.WriteLine("Select a method for calculating the surface of the triangle:");
        Console.WriteLine("1. By given side and an altitude to it");
        Console.WriteLine("2. By given the three sides of the triangle");
        Console.WriteLine("3. By given two sides and an angle between them");
        int userSelect = int.Parse(Console.ReadLine());
        double surface = 0;

        switch (userSelect)
        {
            case 1:
                Console.Write("Enter side: ");
                double sideA = double.Parse(Console.ReadLine());
                Console.Write("Enter altitude to the side: ");
                double altitudeA = double.Parse(Console.ReadLine());
                surface = SurfaceBySideAndAltitude(sideA, altitudeA);
                break;
            case 2:
                Console.WriteLine("Enter side A: ");
                sideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side B: ");
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side C: ");
                double sideC = double.Parse(Console.ReadLine());
                surface = SurfaceByThreeSides(sideA, sideB, sideC);
                break;
            case 3:
                Console.WriteLine("Enter side A: ");
                sideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side B: ");
                sideB = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter angle between the sided: ");
                double angle = double.Parse(Console.ReadLine());
                surface = SurfaceByTwoSidesAndAngle(sideA, sideB, angle);
                break;
            default:
                Console.WriteLine("There is no such method");
                break;
        }

        Console.WriteLine("The surface of the triangle is: {0}", surface);
    }
}