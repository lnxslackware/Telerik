using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;
        int tempDivisor = 1;

        do
        {
            Console.Write("Enter first number: ");
        }
        while (!int.TryParse(Console.ReadLine(), out firstNumber));

        do
        {
            Console.Write("Enter second number: ");
        }
        while (!int.TryParse(Console.ReadLine(), out secondNumber));

        if (firstNumber < secondNumber)
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
        }

        if (secondNumber != 0)
        {
            while (tempDivisor != 0 && firstNumber != 0)
            {
                if (secondNumber != 0)
                {
                    tempDivisor = firstNumber % secondNumber;
                }
                if (tempDivisor != 0)
                {
                    firstNumber = secondNumber % tempDivisor;
                }
                if (firstNumber != 0)
                {
                    secondNumber = tempDivisor % firstNumber;
                }
            }

            Console.Write("The greatest common divisor is: ");

            if (firstNumber == 0)
            {
                Console.WriteLine(tempDivisor);
            }
            if (secondNumber == 0)
            {
                Console.WriteLine(firstNumber);
            }
            if (tempDivisor == 0)
            {
                Console.WriteLine(secondNumber);
            }
        }
        else
        {
            Console.WriteLine("The greatest common divisor is 0");
        }
    }
}