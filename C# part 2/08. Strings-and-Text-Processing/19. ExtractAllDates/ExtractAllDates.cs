/*
 * Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.
 */

using System;
using System.Text.RegularExpressions;
using System.Globalization;

class ExtractAllDates
{
    static void Main()
    {
        //NOTE - 30.13.2014 is not a valid date, 7.11.2014 - not in valid format(dd.MM.yyyy)
        string text = "jiosfahfasiohf sfahio 22.11.2013 hasfilhil fash4fil hsafilh ilashflsa 01.10.2060 hfklh asfiasl 30.13.2014 hfilashilf hasilfhil ashfi23.lashfilsafhl 7.11.2014";
        string datePattern = @"[0-3][0-9]\.[0-1][0-2]\.[0-9][0-9][0-9][0-9]";

        MatchCollection validDatesInText = Regex.Matches(text, datePattern);

        CultureInfo culture = new CultureInfo("en-CA");

        //Printing all matches
        Console.WriteLine("Valid dates in text:");
        foreach (Match date in validDatesInText)
        {
            Console.WriteLine("{0}", DateTime.Parse(date.ToString(), culture, DateTimeStyles.None));
        }
    }
}