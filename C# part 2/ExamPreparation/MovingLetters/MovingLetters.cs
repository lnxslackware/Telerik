using System;
using System.Text;

class MovingLetters
{

    static void Main()
    {
        string[] inputWords = Console.ReadLine().Split(' ');

        //getting the longest word's length
        int longestWordLength = 0;

        foreach (var word in inputWords)
        {
            if (longestWordLength < word.Length)
            {
                longestWordLength = word.Length;
            }
        }

        StringBuilder sb = new StringBuilder();
        //List<char> chars = new List<char>();

        //adding all chars to the list
        for (int i = 0; i < longestWordLength; i++)
        {
            foreach (var word in inputWords)
            {
                if (word.Length > i)
                {
                    sb.Append(word[word.Length - 1 - i]);
                }
            }
        }

        //moving the words
        for (int i = 0; i < sb.Length; i++)
        {
            int steps = char.ToLower(sb[i]) - '`';
            //Console.WriteLine("{0}", steps);
            int newIndex = (steps + i) % sb.Length;

            char tmp = sb[i];
            sb.Remove(i, 1);
            sb.Insert(newIndex, tmp);

            //if (newIndex > i)
            //{
            //}
            //else
            //{
            //    chars.RemoveAt(i - 1);
            //}
        }

        Console.WriteLine(sb);

    }
}