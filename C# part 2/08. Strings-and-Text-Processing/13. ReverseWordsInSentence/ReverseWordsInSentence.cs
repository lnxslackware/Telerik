/*
 * Write a program that reverses the words in given sentence.
 * Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ReverseWordsInSentence
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";

        Stack<string> words = new Stack<string>(sentence.Substring(0, sentence.Length - 1).Split(' '));
        MatchCollection signs = Regex.Matches(sentence, @"\s+|,\s*|\.\s*|!\s*|$");
        Queue<string> punctuation = new Queue<string>();

        foreach (var sign in signs)
        {
            punctuation.Enqueue(sign.ToString());
        }
        
        StringBuilder builder = new StringBuilder();

        while (words.Count > 0)
        {
                builder.Append(words.Pop());
                builder.Append(punctuation.Dequeue());
        }

        sentence = builder.ToString().Trim();

        Console.WriteLine(sentence);
    }
}