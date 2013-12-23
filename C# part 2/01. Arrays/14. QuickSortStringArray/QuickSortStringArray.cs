/*
 * Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
 */

using System;
using System.Collections.Generic;


class QuickSortStringArray
{
    static List<string> QuickSort(List<string> stringList)
    {
        if (stringList.Count <= 1)
        {
            return stringList;
        }

        //list to store the string that are shorter than our pivot element
        List<string> shorter = new List<string>();
        //list to store the string that are longer than our pivot element
        List<string> longer = new List<string>();

        //our pivot element will be the one in the middle
        string pivotElement = stringList[stringList.Count / 2];

        for (int i = 0; i < stringList.Count; i++)
        {
            if (i != stringList.Count / 2)//If the current element is not our pivot element
            {
                if (stringList[i].Length > pivotElement.Length)//if the current string is longer than the pivot
                {
                    longer.Add(stringList[i]);
                }
                if (stringList[i].Length < pivotElement.Length)//if the current string is longer than the pivot
                {
                    shorter.Add(stringList[i]);
                }
            }
        }

        return Concatenate(QuickSort(shorter), pivotElement, QuickSort(longer));
    }

    static List<string> Concatenate(List<string> first, string pivot, List<string> second)
    {
        List<string> concatenatedArray = new List<string>();
        concatenatedArray.AddRange(first);
        concatenatedArray.Add(pivot);
        concatenatedArray.AddRange(second);
        return concatenatedArray;
    }
    static void Main()
    {
        List<string> intList = new List<string>
        {
                                   "fsafsafsfsafsa",
                                   "fsafasfsa",
                                   "fsafsa",
                                   "fsafsafsafsafs",
                                   "fsafsafsafsafsa",
                                   "fswqfsafwq",
                                   "fwqfrw2r42as",
                                   "jifosjhfsa",
                                   "fsahufsafsa"
        };

        //Print the unsorted list
        Console.WriteLine(new string('-', 9));
        Console.WriteLine("Unsorted:");
        Console.WriteLine(new string('-', 9));
        Console.WriteLine(string.Join("\n", intList));

        Console.WriteLine();

        //Print the sortedList
        Console.WriteLine(new string('-', 18));
        Console.WriteLine("Sorted(by length):");
        Console.WriteLine(new string('-', 18));
        Console.WriteLine(string.Join("\n", QuickSort(intList)));
    }
}