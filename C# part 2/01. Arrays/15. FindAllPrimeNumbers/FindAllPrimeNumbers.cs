/*
 * Write a program that finds all prime numbers in the range [1...10 000 000].
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
 */

using System;

class FindAllPrimeNumbers
{
    static void Main()
    {
        int count = 10000;
        int[] numbers = new int[count];
        int currentFirstElement = 2;

        //Initializing the array
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0 || i == 1)
            {
                numbers[i] = 0; //0 means the number is NOT prime
            }
            else
            {
                numbers[i] = 1; //1 means the number is considered prime at the moment
            }
        }

        for (int i = 0; i < Math.Sqrt(numbers.Length); i++)
        {
            if (numbers[i] == 1)
            {
                //Set the variable currentFirstElement to the next number marked as "consider prime"(1)
                currentFirstElement = i;
            }

            //Set the next elements to NOT prime
            for (int j = 1; j * currentFirstElement < numbers.Length; j++)
            {
                if (j >= currentFirstElement)
                {
                    numbers[j * currentFirstElement] = 0;
                }
            }
        }

        //Print all numbers(indexes) where the value is set to 1(prime number)
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 1)
            {
                Console.Write(" {0}", i);
            }
        }
    }
}