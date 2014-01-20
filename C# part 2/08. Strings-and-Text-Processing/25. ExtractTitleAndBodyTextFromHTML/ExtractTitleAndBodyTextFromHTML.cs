/*
 * Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
 */

using System;
using System.Text.RegularExpressions;

class ExtractTitleAndBodyTextFromHTML
{
    static void Main()
    {
        string htmlPath = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        string textOnlyPattern = @"(?<=^|>)[^><]+?(?=<|$)";

        MatchCollection matches = Regex.Matches(htmlPath, textOnlyPattern);

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}