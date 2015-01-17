/*
 * Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
 */

namespace _15_AgeAfterTenYears
{
    using System;

    class AgeAfterTenYears
    {
        static void Main()
        {
            Console.Write("Enter your birthday in format(dd.mm.yyyy): ");
            string userInput = Console.ReadLine().Replace('/', '.').Replace(',', '.');
            DateTime inputDate = DateTime.Parse(userInput);
            DateTime currentDate = DateTime.Now;
            int differenceInYears = currentDate.Year - inputDate.Year;
            //check if the birthday is passed or it is yet to come
            var differenceBetweenDates = inputDate.AddYears(differenceInYears) - currentDate;
            if (differenceBetweenDates.TotalDays > 0)
            {
                differenceInYears--;
            }

            Console.WriteLine("Now you are {0} years old.", differenceInYears);
            int ageAfterTenYears = differenceInYears + 10;
            Console.WriteLine("After 10 years you will be {0} years old.", ageAfterTenYears);
        }
    }
}