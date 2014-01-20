/*
 * Write a program that reads a string, reverses it and prints the result at the console.
 * Example: "sample" -> "elpmas".
 */

using System;
using System.Text;

class ReverseString
{
    static string Reverse_Variant2(string str)
    {
        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            builder.Insert(0, str[i]);
        }

        return builder.ToString();
    }

    static string Reverse_Variant1(string str)
    {
        char[] temp = str.ToCharArray();
        Array.Reverse(temp);
        return new string(temp);
    }

    static void Main()
    {
        string sampleString = "sample";
        string secondSampleString = sampleString;
        
        //First way
        sampleString = Reverse_Variant1(sampleString);
        Console.WriteLine(sampleString);

        //second way
        secondSampleString = Reverse_Variant2(sampleString);
        Console.WriteLine(sampleString);
    }
}