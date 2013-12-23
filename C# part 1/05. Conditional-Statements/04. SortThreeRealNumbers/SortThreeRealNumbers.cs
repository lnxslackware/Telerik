using System;

class SortThreeRealNumbers
{
    static void Main()
    {
        Console.Write("Enter first real number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second real number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third real number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine(firstNumber);

            if (secondNumber > thirdNumber)
            {
                Console.WriteLine(secondNumber);
                Console.WriteLine(thirdNumber);
            }
            if (thirdNumber > secondNumber)
            {
                Console.WriteLine(thirdNumber);
                Console.WriteLine(secondNumber);
            }
        }
        if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine(secondNumber);

            if (firstNumber > thirdNumber)
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(thirdNumber);
            }
            if (thirdNumber > firstNumber)
            {
                Console.WriteLine(thirdNumber);
                Console.WriteLine(firstNumber);
            }
        }
        if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine(thirdNumber);

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
            }
            if (secondNumber > firstNumber)
            {
                Console.WriteLine(secondNumber);
                Console.WriteLine(firstNumber);
            }
        }
    }
}