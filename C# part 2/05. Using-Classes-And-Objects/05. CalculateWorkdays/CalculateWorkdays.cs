/*
 * Write a method that calculates the number of workdays between today and given date, passed as parameter. 
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */

using System;

class CalculateWorkdays
{
    static bool CheckIfWorkday(DateTime date)
    {
        bool result = true;

        DateTime[] holidayList = 
        {
            new DateTime(2014, 3, 3),
            new DateTime(2014, 4, 18),
            new DateTime(2014, 4, 19),
            new DateTime(2014, 4, 20),
            new DateTime(2014, 5, 1),
            new DateTime(2014, 5, 6)
        };

        if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
        {
            result = false;
        }
        else
        {
            foreach (DateTime holiday in holidayList)
            {
                if (date == holiday)
                {
                    result = false;
                }
            }
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter the end date for your check");
        Console.Write("(Input format - Year Month Date): ");
        string[] inputetDate = Console.ReadLine().Split(' ');
        int year = int.Parse(inputetDate[0]);
        int month = int.Parse(inputetDate[1]);
        int day = int.Parse(inputetDate[2]);
        DateTime endDate = new DateTime(year, month, day);
        //DateTime startingDate = DateTime.Today;
        int workingDays = 0;

        for (DateTime i = DateTime.Today; i <= endDate; i = i.AddDays(1))
        {
            if (CheckIfWorkday(i) == true)
            {
                workingDays++;
            }
        }

        Console.WriteLine("The count of the working days till {0} are {1}", endDate, workingDays);
    }
}