using System;
using System.Globalization;

class DateAfter6Hours
{
    static void Main()
    {
        Console.WriteLine("Enter a date in format Day.Month.Year Hours:Minutes:Seconds");
        Console.Write("Date: ");
        DateTime inputedDate = DateTime.Parse(Console.ReadLine(), new CultureInfo("bg-BG"), DateTimeStyles.AdjustToUniversal);
        //Console.WriteLine(inputedDate);
        //string[] inputedDateAndTime = Console.ReadLine().Split(' ');
        //int days = int.Parse(inputedDateAndTime[0].Split('.')[0]);
        //int months = int.Parse(inputedDateAndTime[0].Split('.')[1]);
        //int years = int.Parse(inputedDateAndTime[0].Split('.')[2]);
        //int hours = int.Parse(inputedDateAndTime[1].Split('.')[0]);
        //int minutess = int.Parse(inputedDateAndTime[1].Split('.')[1]);
        //int seconds = int.Parse(inputedDateAndTime[1].Split('.')[2]);

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