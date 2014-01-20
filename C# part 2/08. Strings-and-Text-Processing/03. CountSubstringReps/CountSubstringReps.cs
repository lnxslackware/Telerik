/*
 * Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
 */

using System;

class CountSubstringReps
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.".ToLower();
        string searchedSubstring = "in";
        int repsCount = 0;
        int previousFoundIndex = -1;

        while ((previousFoundIndex = text.IndexOf(searchedSubstring, previousFoundIndex + 1 ))> -1)
        {
            repsCount++;
        }

        Console.WriteLine("The result is: {0}", repsCount);
    }
}