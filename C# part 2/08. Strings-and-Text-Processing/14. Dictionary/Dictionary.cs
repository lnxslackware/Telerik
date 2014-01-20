/*
 * A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and translates it by using the dictionary. 
 */

using System;
using System.Collections.Generic;

class Dictionary
{
    static void Main()
    {
        string dictionary = @".NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes
";
        List<string> words = new List<string>();
        List<string> meanings = new List<string>();
        char[] lineseparators = { '\r', '\n' };
        string[] lines = dictionary.Split(lineseparators, StringSplitOptions.RemoveEmptyEntries);

        string[] separators = { " – " };

        foreach (var line in lines)
        {
            string[] wordAndMeaning = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            words.Add(wordAndMeaning[0].ToLower());
            meanings.Add(wordAndMeaning[1]);
        }

        Console.Write("Input a word to search in the dictionary: ");
        string word = Console.ReadLine().ToLower();

        int indexOfSearchedWord = words.IndexOf(word);

        if (indexOfSearchedWord < 0)
        {
            Console.WriteLine("The word is not in the dictionary.");
        }
        else
        {
            Console.WriteLine("Meaning: {0}", meanings[indexOfSearchedWord]);
        }

    }
}