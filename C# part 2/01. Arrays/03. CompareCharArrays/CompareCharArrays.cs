using System;

class CompareCharArrays
{
    static void Main()
    {
        //We implement and initialize the first array
        Console.Write("Enter first array length: ");
        int firstArrayLength = int.Parse(Console.ReadLine());

        Console.WriteLine("Input the values of the array: ");

        char[] firstArray = new char[firstArrayLength];

        for (int i = 0; i < firstArrayLength; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        //Then for the second array
        Console.Write("Enter second array length: ");
        int secondArrayLength = int.Parse(Console.ReadLine());

        Console.WriteLine("Input the values of the array: ");

        char[] secondArray = new char[firstArrayLength];

        for (int i = 0; i < firstArrayLength; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        bool firstOneFirst = false;
        bool secondOneFirst = false;
        int smallerArray = firstArrayLength;
        int largerArray = secondArrayLength;

        if (firstArrayLength > secondArrayLength)
        {
            smallerArray = secondArrayLength;
            largerArray = firstArrayLength;
        }

        for (int i = 0; i < smallerArray; i++)
        {
            if ((int)firstArray[i] > (int)secondArray[i])
            {
                secondOneFirst = true;
                break;
            }
            else if ((int)firstArray[i] < (int)secondArray[i])
            {
                firstOneFirst = true;
                break;
            }
            else
            {
                continue;
            }
        }

        if (firstOneFirst == true && secondOneFirst == false)
        {
            Console.WriteLine("The first array is lexicographically first");
        }
        else if (firstOneFirst == false && secondOneFirst == true)
        {
            Console.WriteLine("The second array is lexicographically first");
        }
        else if (firstOneFirst == true && secondOneFirst == true)
        {
            if (firstArrayLength == secondArrayLength)
            {
                Console.WriteLine("The two arrays are lexicographically equal");
            }
            else if (firstArrayLength < secondArrayLength)
            {
                Console.WriteLine("The first array is lexicographically first");
            }
            else
            {
                Console.WriteLine("The second array is lexicographically first");
            }
        }
        else
        {
            Console.WriteLine("Unknown error");
        }

    }
}