using System;
using System.Collections.Generic;

class CountDifferentCharsInString
{
    static void Main()
    {
        string text = "ohfasioghfouqwgasfmgfqwuiofguasiofbhoiashgphmsaiopfimoasfas fsahofhasopi fs jfsajfasjfasj";
        Dictionary<char, int> charsCount = new Dictionary<char, int>();

        //ToLower() to performing case INsensitive comparison
        text = text.ToLower();

        for (int i = 0; i < text.Length; i++)
        {
            if (!charsCount.ContainsKey(text[i]))
            {
                int reps = 1;

                for (int j = i + 1; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        reps++;
                    }
                }

                charsCount.Add(text[i], reps);
            }
        }

        //printing all characters in the text and theyr reps

        foreach (var character in charsCount)
        {
            Console.WriteLine("{0} -> {1}", character.Key, character.Value);
        }
    }
}