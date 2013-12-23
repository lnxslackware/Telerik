using System;

class QuotedStrings
{
    static void Main()
    {
        string firstString = "The \"use\" of quotations causes difficulties.";
        string secondString = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("First quote is:");
        Console.WriteLine(firstString);
        Console.WriteLine("Second quote is:");
        Console.WriteLine(secondString);
    }
}