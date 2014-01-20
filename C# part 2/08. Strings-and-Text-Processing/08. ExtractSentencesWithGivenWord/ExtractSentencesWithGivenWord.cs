/*
 * Write a program that extracts from a given text all sentences containing given word.
 * Consider that the sentences are separated by "." and the words – by non-letter symbols.
 */

using System;

class ExtractSentencesWithGivenWord
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";

        string[] sentences = text.Split('.');

        //printing the sentences containing the word
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(" " + word + " "))
            {
                Console.WriteLine(sentences[i].Trim());
            }
        }
    }
}