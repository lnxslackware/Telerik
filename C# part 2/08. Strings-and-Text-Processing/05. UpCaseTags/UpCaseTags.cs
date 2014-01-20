/*
 * You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 
 */

using System;
using System.Collections.Generic;

class UpCaseTags
{
    static void Main()
    {
        List<int> openTagsEndIndexes = new List<int>();
        List<int> closeTagsEndIndexes = new List<int>();
        List<string> subStringsToBeUpper = new List<string>();
        int lastFoundIndex = -1;
        string openTag = "<upcase>";
        string closeTag = "</upcase>";
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        //Adding to the lists all indexes of the last characters of the opening and closing tags.
        while ((lastFoundIndex = text.IndexOf(openTag, lastFoundIndex + 1)) > -1)
        {
            openTagsEndIndexes.Add(lastFoundIndex);
        }

        lastFoundIndex = -1;

        while ((lastFoundIndex = text.IndexOf(closeTag, lastFoundIndex + 1)) > -1)
        {
            closeTagsEndIndexes.Add(lastFoundIndex);
        }

        //Adding all the substrings that have to be uppercase to the third list
        for (int i = 0; i < openTagsEndIndexes.Count; i++)
        {
            int startingIndex = openTagsEndIndexes[i] + openTag.Length;
            int substringLength = (closeTagsEndIndexes[i] - openTagsEndIndexes[i]) - (openTag.Length);
            subStringsToBeUpper.Add(text.Substring(startingIndex, substringLength));
        }

        //Replacing all substrings with uppercase
        foreach (var item in subStringsToBeUpper)
        {
            text = text.Replace(openTag + item + closeTag, item.ToUpper());
        }

        //Printing the new string
        Console.WriteLine(text);
    }
}