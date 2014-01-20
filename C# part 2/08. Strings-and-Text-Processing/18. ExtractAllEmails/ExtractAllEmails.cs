/*
 * Write a program for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */

using System;
using System.Text.RegularExpressions;

class ExtractAllEmails
{
    static void Main()
    {
        string text = "fsafsa fsa fs, fsa @ fsafas, fsafas@fsafsa.com fsafsjopfsa fjsap-fsafsa jiofs fsa_jfio@fsa.df";
        string emailPattern = @"[a-zA-Z\._]+@[a-zA-Z\._0-9]+\.[a-z]{2,4}";

        //extracting emails
        MatchCollection emails = Regex.Matches(text, emailPattern);

        //Printing all found emails
        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }
    }
}