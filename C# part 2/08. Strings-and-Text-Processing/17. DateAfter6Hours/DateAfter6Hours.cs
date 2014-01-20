/*
 * Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */

using System;
using System.Globalization;

class DateAfter6Hours
{
    static void Main()
    {
        Console.WriteLine("Enter a date in format Day.Month.Year Hours:Minutes:Seconds");
        Console.Write("Date: ");
        DateTime inputedDate = DateTime.Parse(Console.ReadLine(), new CultureInfo("bg-BG"), DateTimeStyles.None);

        DateTime newDate = inputedDate.AddHours(6);
        newDate = newDate.AddMinutes(30);
        string dayOfWeek = string.Empty;

        switch (newDate.DayOfWeek)
        {
            case DayOfWeek.Friday:
                dayOfWeek = "Петък";
                break;
            case DayOfWeek.Monday:
                dayOfWeek = "Понеделник";
                break;
            case DayOfWeek.Saturday:
                dayOfWeek = "Събота";
                break;
            case DayOfWeek.Sunday:
                dayOfWeek = "Неделя";
                break;
            case DayOfWeek.Thursday:
                dayOfWeek = "Четвъртък";
                break;
            case DayOfWeek.Tuesday:
                dayOfWeek = "Вторник";
                break;
            case DayOfWeek.Wednesday:
                dayOfWeek = "Сряда";
                break;
            default:
                break;
        }

        Console.WriteLine("{0:dd.M.yyyy H:mm:ss}, {1}", newDate, dayOfWeek);
    }
}