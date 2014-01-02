/*
 * Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
 * * Use the method from the previous exercise.
 */

using System;

class FirstElementBiggerThanTheNeighbors
{
    static int IndexOfFirstBiggerElement(int[] arr)
    {
        int result = -1;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            //calling the method from Project 6
            if (BiggerThanTheNeighbors.ElementGraterThanNeighbors(arr, i) == true)
            {
                result = i;
                break;
            }
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

        //calling the method
        int firstFoundIndex = IndexOfFirstBiggerElement(numbers);

        //output
        if (firstFoundIndex > -1)
        {
            Console.WriteLine("The index of the first element that is greater than its neighbor elements is {0} and the value at this position is {1}", firstFoundIndex, numbers[firstFoundIndex]);
        }
        else
        {
            Console.WriteLine("There is no element that is bigger than its neighbors.");
        }
    }
}