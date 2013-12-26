/*
 * You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them). 
 */

using System;

class SortStringArrayByLength
{
    static void SortArrayByLength(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i].Length > arr[j].Length)
                {
                    string tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
        }
    }

    static void PrintStringArray(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("index: {0} -> {1}", i, arr[i]);
        }
    }
    static void Main()
    {
        //Reading the string from the user
        Console.Write("How many words do you want to input? ");
        int count = int.Parse(Console.ReadLine());

        string[] words = new string[count];
        Console.WriteLine("Enter the words:");
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = Console.ReadLine();
        }

        //Clearing the console
        Console.Clear();

        //Print the unsorted array
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Your array was:");
        PrintStringArray(words);

        //Calling the sort method
        SortArrayByLength(words);
        
        //Print the sorted array
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Your array after sort:");
        PrintStringArray(words);
        Console.WriteLine(new string('-', 20));
    }
}