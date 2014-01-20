/*
 * Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
 */

using System;

class DaysBetweenTwoDates
{
    static void Main()
    {
        Console.WriteLine("Enter the two dates in format: Day.Month.Year");
        Console.Write("First date:");
        string[] firstDate = Console.ReadLine().Split('.');
        Console.Write("Second date:");
        string[] secondDate = Console.ReadLine().Split('.');

        DateTime first = new DateTime(int.Parse(firstDate[2]), int.Parse(firstDate[1]), int.Parse(firstDate[0]));
        DateTime second = new DateTime(int.Parse(secondDate[2]), int.Parse(secondDate[1]), int.Parse(secondDate[0]));

        TimeSpan difference = second - first;

        Console.WriteLine(Math.Abs(difference.Days));
    }
}