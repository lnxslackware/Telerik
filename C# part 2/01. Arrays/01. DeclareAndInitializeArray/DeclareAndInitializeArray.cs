/*
 * Write a program that allocates array of 20 integers and 
 * initializes each element by its index multiplied by 5. 
 * Print the obtained array on the console.
 */

using System;

class DeclareAndInitializeArray
{
    static void Main()
    {
        //declaring the array
        int[] newArray = new int[20];

        //setting the values of the elements in the array and printing them afterwards
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = i * 5;
            Console.WriteLine("array element {0} = {1}", i, newArray[i]);
        }
    }
}