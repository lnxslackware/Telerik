using System;
using System.Text;

class ReplaceForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string listOfForbiddenWords = "PHP, CLR, Microsoft";
        char[] delimiters = { ' ', ','};
        string[] forbiddenWords = listOfForbiddenWords.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder builder = new StringBuilder(text);

        foreach (var item in forbiddenWords)
        {
            builder.Replace(item, new string('*', item.Length));
        }

        text = builder.ToString();

        Console.WriteLine(text);
    }
}