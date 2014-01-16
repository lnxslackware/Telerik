/*
 * Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
 */

using System;

class IsTheYearLeap
{
    static void Main()
    {
        Console.Write("Enter the year: ");
        int selectedYear = int.Parse(Console.ReadLine());
        bool leap = DateTime.IsLeapYear(selectedYear);

        Console.WriteLine("The year {0} {1} leap.", selectedYear, leap ? "is" : "is not");
    }
}