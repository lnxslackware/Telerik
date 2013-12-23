/*
 * Write a program that reads two arrays from the console and compares them element by element.
 */

using System;

class CompareTwoArrays
{
    static void Main()
    {
        //First we ask the user for the length of the two arrays

        //For the first one
        Console.Write("Enter length for first array: ");

        int firstArrayLength = int.Parse(Console.ReadLine());
        int[] firstArray = new int[firstArrayLength];

        //We ask for the values of the first array
        Console.WriteLine("Enter first array's elements:");

        //and initialize them
        for (int i = 0; i < firstArrayLength; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        //Then we ask the user for the length of the second array
        Console.Write("Enter length for second array: ");

        //And for the second one
        int secondArrayLength = int.Parse(Console.ReadLine());

        //int secondArrayLength = int.Parse(Console.ReadLine());
        int[] secondArray = new int[secondArrayLength];

        //Now the same thing for the second array
        Console.WriteLine("Enter second array's elements:");

        //once again initialization
        for (int i = 0; i < secondArrayLength; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        int shorterArray = firstArrayLength;

        Console.Write("The arrays are ");

        if (firstArrayLength != secondArrayLength)
        {
            if (firstArrayLength < secondArrayLength)
            {
                shorterArray = firstArrayLength;
                Console.WriteLine("not equal - the second one has more elements.");
            }
            else
            {
                shorterArray = secondArrayLength;
                Console.WriteLine("not equal - the first one has more elements.");
            }
        }
        else
        {
            Console.WriteLine("with equal length.");
        }

        Console.WriteLine();

        bool difference = false;

        //we need compare the values of the elements
        for (int i = 0; i < shorterArray; i++)
        {
            Console.Write("firstArray[{0}] = {1} ", i, firstArray[i]);
            //if we find difference there is no need to check the other elements explicitly
            if (firstArray[i] != secondArray[i])
            {
                difference = true;
                Console.Write("is not equal to ");
            }
            else
            {
                Console.Write("is equal to ");
            }
            Console.WriteLine("secondArray[{0}] = {1}", i, secondArray[i]);
        }
        Console.WriteLine();
        Console.WriteLine("{0}", difference ? "The two arrays are not equal, they have difference in theyr elements." : "The two arrays are equal.");
    }
}