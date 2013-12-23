using System;

class FindGreatestNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        int fourthNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        int fifthNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber)
        {
            Console.WriteLine("The greatest number is the first -> {0}", firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber)
        {
            Console.WriteLine("The greatest number is the second -> {0}", secondNumber);
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
        {
            Console.WriteLine("The greatest number is the third -> {0}", thirdNumber);
        }
        else if (fourthNumber > firstNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber)
        {
            Console.WriteLine("The greatest number is the fourth -> {0}", fourthNumber);
        }
        else
        {
            Console.WriteLine("The greatest number is the fifth -> {0}", fifthNumber);
        }
    }
}