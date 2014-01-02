/*
 * Write a method that checks if the element at given position in 
 * given array of integers is bigger than its two neighbors (when such exist).
 */

using System;

public class BiggerThanTheNeighbors
{
    public static bool ElementGraterThanNeighbors(int[] arr, int index)
    {
        bool result = true;

        if (index - 1 >= 0 && index + 1 < arr.Length)
        {
            if (arr[index] < arr[index - 1] || arr[index] < arr[index + 1])
            {
                result = false;
            }
        }
        else
        {
            result = false;
        }

        return result;
    }

    static void Main()
    {
        //Reading user input
        Console.Write("How many numbers do you want in the array? ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrayLength];
        Console.WriteLine("Enter the values in the array(separated by single space):");
        string userInput = Console.ReadLine();
        string[] userInputAsArray = userInput.Split(' ');

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(userInputAsArray[i]);
        }

        Console.Write("Enter the index you want to check: ");
        int numberIndex = int.Parse(Console.ReadLine());

        //Getting the result
        bool checkResult = ElementGraterThanNeighbors(numbers, numberIndex);

        //Output
        Console.WriteLine("The result is: {0}", checkResult);
    }
}