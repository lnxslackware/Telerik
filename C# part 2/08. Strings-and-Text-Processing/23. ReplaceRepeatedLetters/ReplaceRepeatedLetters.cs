/*
 * Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".
 */

using System;
using System.Collections.Generic;

class ReplaceRepeatedLetters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        List<char> letters = new List<char>();

        letters.Add(text[0]);

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != letters[letters.Count - 1])
            {
                letters.Add(text[i]);
            }      
        }

        //printing the letters
        foreach (char letter in letters)
        {
            Console.Write(letter);
        }
        Console.WriteLine();
    }
}