using System;

class DivisibleByFive
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int smallerNumber = firstNumber;
        int biggerNumber = secondNumber;

        int counter = 0;
 
        if (firstNumber > secondNumber)
        {
            smallerNumber = secondNumber;
            biggerNumber = firstNumber;
        }
        
        for (int i = smallerNumber; i <= biggerNumber; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}