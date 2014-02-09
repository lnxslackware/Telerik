using System;
using System.Collections.Generic;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int numberOfWords = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();

        for (int i = 0; i < numberOfWords; i++)
        {
            words.Add(Console.ReadLine());
        }

        //reordering
        for (int i = 0; i < words.Count; i++)
        {
            int newPosition = words[i].Length % (words.Count + 1);
            words.Insert(newPosition, words[i]);
            if (newPosition < i)
            {
                words.RemoveAt(i + 1);
            }
            else
            {
                words.RemoveAt(i);
            }
        }

        //getting the length of the result
        int longestWordLength = 0;
        foreach (var word in words)
        {
            if (word.Length > longestWordLength)
            {
                longestWordLength = word.Length;
            }
        }

        StringBuilder result = new StringBuilder();

        //printing
        for (int i = 0; i < longestWordLength; i++)
        {
            foreach (var word in words)
            {
                if (word.Length > i)
                {
                    result.Append(word[i]);
                }
            }
        }

        Console.WriteLine(result);
    }
}