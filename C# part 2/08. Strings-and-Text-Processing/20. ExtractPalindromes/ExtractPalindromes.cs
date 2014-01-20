/*
 * Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */

using System;

class ExtractPalindromes
{
    static void Main()
    {
        string text = "jhiofsahopifas abba fkasjhasfk neven fksahkfas, lamal, ghasfgfask exe";
        char[] wordsSeparators = { ',', ' ', '.' };
        string[] words = text.Split(wordsSeparators, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            bool isPalindrom = true;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrom = false;
                    break;
                }
            }

            if (isPalindrom)
            {
                Console.WriteLine(word);
            }
        }
    }
}