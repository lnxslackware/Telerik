/*
 * Write a method that adds two positive integer numbers represented as arrays of digits 
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits.
 */

using System;

class AddBigIntegerNumbers
{
    static int[] StringToReversedIntArr(string str)
    {
        int[] result = new int[str.Length];

        for (int i = str.Length - 1, j = 0; i >= 0; i--, j++)
        {
            result[j] = int.Parse(str[i].ToString());
        }

        return result;
    }

    static int[] AddBigNumbers(string firstNumberAsString, string secondNumberAsString)
    {
        int[] shorterNumber;
        int[] longerNumber;

        if (firstNumberAsString.Length >= secondNumberAsString.Length)
        {
            shorterNumber = StringToReversedIntArr(secondNumberAsString);
            longerNumber = StringToReversedIntArr(firstNumberAsString);
        }
        else
        {
            shorterNumber = StringToReversedIntArr(firstNumberAsString);
            longerNumber = StringToReversedIntArr(secondNumberAsString);
        }

        //Creating a new array for the result
        int[] sum = new int[longerNumber.Length + 1];

        int sumOfElements = 0;

        //Adding the two numbers
        for (int i = 0; i < longerNumber.Length; i++)
        {
            if (i < shorterNumber.Length)
            {
                sumOfElements = shorterNumber[i] + longerNumber[i] + sum[sum.Length - 1 - i];

            }
            else
            {
                sumOfElements = longerNumber[i] + sum[sum.Length - 1 - i];
            }

            sum[sum.Length - 1 - i] = sumOfElements % 10;
            sum[sum.Length - 2 - i] = sumOfElements / 10;

        }

        return sum;
    }
    static void Main()
    {
        //Input
        Console.WriteLine("Enter the firtst big number:");
        string firstNumberAsString = Console.ReadLine();
        Console.WriteLine("Enter the second big number:");
        string secondNumberAsString = Console.ReadLine();

        //Calling the method to add the two numbers and print the result
        int[] resultNumber = AddBigNumbers(firstNumberAsString, secondNumberAsString);

        //Output
        string output = string.Join("", resultNumber).TrimStart('0'); //We get rid of the leading zero if there is one
        Console.WriteLine("The sum of the two numbers is:\n{0}", output);
    }
}