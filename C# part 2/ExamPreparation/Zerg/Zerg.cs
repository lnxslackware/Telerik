using System;
using System.Text.RegularExpressions;
using System.Numerics;

class Zerg
{
    static BigInteger calculatePow(int index)
    {
        if (index == 0)
        {
            return 1;
        }

        BigInteger pow = 1;

        for (int i = 0; i < index; i++)
        {
            pow *= 15; 
        }

        return pow;
    }

    static void Main()
    {
        string zergMessage = Console.ReadLine();
        string wordsPattern = @"[A-Z][a-z]{3}";
        string[] dictionary = { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };

        MatchCollection words = Regex.Matches(zergMessage, wordsPattern);

        BigInteger answer = 0;

        for (int i = words.Count - 1, j = 0; i >= 0; i--, j++)
        {
            int value = Array.IndexOf(dictionary, words[i].ToString());
            answer += (BigInteger)value * calculatePow(j);
        }

        Console.WriteLine(answer);
    }
}