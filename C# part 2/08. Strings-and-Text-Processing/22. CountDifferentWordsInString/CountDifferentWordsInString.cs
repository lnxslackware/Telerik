/*
 * Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
 */

using System;
using System.Collections.Generic;

class CountDifferentWordsInString
{
    static void Main()
    {
        string text = "ohfasioghf ouqwgasfmgfqwuio fguasiofbhoiash, fguasiofbhoiash fguasiofbhoiash. gphmsaiopfimoasfas fsahofhasopi fs jfsajfasjfasj";
        
        //ToLower() to performing case INsensitive comparison
        text = text.ToLower();
        char[] separators = {' ', ',', '.'};
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        
        Dictionary<string, int> wordsCount = new Dictionary<string, int>();

        //ToLower() to performing case INsensitive comparison
        text = text.ToLower();

        for (int i = 0; i < words.Length; i++)
        {
            if (!wordsCount.ContainsKey(words[i]))
            {
                int reps = 1;

                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        reps++;
                    }
                }

                wordsCount.Add(words[i], reps);
            }
        }

        //printing all characters in the text and theyr reps

        foreach (var word in wordsCount)
        {
            Console.WriteLine("{0} -> {1}", word.Key, word.Value);
        }
    }
}