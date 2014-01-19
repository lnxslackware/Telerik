using System;
using System.Text.RegularExpressions;

class ExtractAllEmails
{
    static void Main()
    {
        string text = "fsafsa fsa fs, fsa @ fsafas, fsafas@fsafsa.com fsafsjopfsa fjsap-fsafsa jiofs fsa_jfio@fsa.df";
        string emailPattern = @"[a-zA-Z._]+@[a-zA-Z._]+";

        //extracting emails
        MatchCollection emails = Regex.Matches(text, emailPattern);

        //Printing all found emails
        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }
    }
}