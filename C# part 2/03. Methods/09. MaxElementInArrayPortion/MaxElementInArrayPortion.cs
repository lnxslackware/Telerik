/*
 * Write a method that return the maximal element in a portion of array of integers starting at given index. 
 * Using it write another method that sorts an array in ascending / descending order.
 */

using System;

class MaxElementInArrayPortion
{
    static int GetMaxElement(int[] arr, int startIndex, int endIndex)
    {
        int maximalElementIndex = startIndex;

        for (int i = startIndex + 1; i < endIndex; i++)
        {
            if (arr[i] > arr[maximalElementIndex])
            {
                maximalElementIndex = i;
            }
        }

        return maximalElementIndex;
    }

    static void SortArray(int[] arr, string order = "asc")
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int endIndex = arr.Length - i;

            if (order == "asc")
            {
                //for ascending order we need to set the last element of the array and check the rest for the maximal element again
                int currentMaxElementIndex = GetMaxElement(arr, 0, endIndex);

                if (currentMaxElementIndex < endIndex - 1)
                {
                    SwapElements(arr, arr.Length - 1 - i, currentMaxElementIndex);
                }
            }
            else
            {
                //for descending order we need to set the first element and then check the rest
                int currentMaxElementIndex = GetMaxElement(arr, i, arr.Length);

                if (currentMaxElementIndex > i)
                {
                    SwapElements(arr, i, currentMaxElementIndex);
                }
            }
        }
    }

    static void SwapElements(int[] arr, int firstElementIndex, int secondElementIndex)
    {
        int temp = arr[firstElementIndex];
        arr[firstElementIndex] = arr[secondElementIndex];
        arr[secondElementIndex] = temp;
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }

    static void Main()
    {
        int[] testArray =
        {
            535,
            99,
            42,
            53,
            3,
            5,
            64,
            42,
            532,
            33,
            53,
            5
        };

        int maxElementIndex = GetMaxElement(testArray, 9, testArray.Length);

        //Print max element
        Console.WriteLine("The maximal element is {0}", testArray[maxElementIndex]);

        //Print array in ascending sort
        SortArray(testArray, "asc");
        PrintArray(testArray);

        //Print array in descending order
        SortArray(testArray, "desc");
        PrintArray(testArray);

    }
}