using System;
using System.Collections.Generic;
using System.Text;

class ReverseWordsInSentence
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        
        List<string> sentenceWords = new List<string>(sentence.Substring(0, sentence.Length - 1).Split(' '));
        sentenceWords.Insert(0, sentence[sentence.Length - 1].ToString());

        StringBuilder builder = new StringBuilder();

        for (int i = sentenceWords.Count -1; i >= 0; i--)
        {
            if (i != sentenceWords.Count - 1 && i != 0)
            {
                builder.Append(" ");
            }
            builder.Append(sentenceWords[i]);
        }

        sentence = builder.ToString().Trim();

        Console.WriteLine(sentence);
    }
}