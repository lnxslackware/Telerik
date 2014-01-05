/*
 * Write a program that can solve these tasks:
 *      Reverses the digits of a number
 *      Calculates the average of a sequence of integers
 *      Solves a linear equation a * x + b = 0
 * Create appropriate methods.
 * Provide a simple text-based menu for the user to choose which task to solve.
 * Validate the input data:
 *      The decimal number should be non-negative
 *      The sequence should not be empty
 *      a should not be equal to 0
 */

using System;

class UserSelectedTask
{
    static void ReverseDigits(string str)
    {
        string ReversedNumberAsString = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            ReversedNumberAsString += str[i];
        }

        Console.WriteLine(ReversedNumberAsString);
    }

    static void CalculateAverage(int[] arr)
    {
        long sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        decimal result = (decimal)sum / arr.Length;

        Console.WriteLine(result);
    }

    static void SolveLinearEquation(decimal a, decimal b)
    {
        decimal x = (-1.0M * b) / a;
        Console.WriteLine(x);
    }

    static int[] ReadSequenceOfNumbers(string input)
    {
        string[] inputedNumbersAsArray = input.Split(' ');
        int[] numbers = new int[inputedNumbersAsArray.Length];

        for (int i = 0; i < inputedNumbersAsArray.Length; i++)
        {
            numbers[i] = int.Parse(inputedNumbersAsArray[i]);
        }

        return numbers;
    }

    static void Main()
    {
        int userChoice = 0;

        do
        {
            Console.WriteLine("Select one of the tasks:");
            Console.WriteLine("1. Reverses the digits of a number");
            Console.WriteLine("2. Calculates the average of a sequence of integers");
            Console.WriteLine("3. Solves a linear equation a * x + b = 0");

        } while (!int.TryParse(Console.ReadLine(), out userChoice));

        Console.WriteLine();

        switch (userChoice)
        {
            case 1:
                Console.WriteLine("You have selected: 1 - To reverse the digits of a number");
                Console.Write("Input positive decimal number:");

                string userInput = Console.ReadLine();

                while (int.Parse(userInput) < 0)
                {
                    Console.Write("The number must be POSITIVE, try again:");
                    userInput = Console.ReadLine();
                }

                Console.Write("Your reversed number is: ");

                ReverseDigits(userInput);
                break;
            case 2:
                Console.WriteLine("You have selected: 2 - To calculate the average of a sequence of integers");
                Console.WriteLine("Input the integer numbers separated by a single space:");

                userInput = Console.ReadLine();

                while (userInput == string.Empty)
                {
                    Console.WriteLine("You did not enter any numbers, try again:");
                    userInput = Console.ReadLine();
                }

                int[] numbers = ReadSequenceOfNumbers(userInput);

                Console.Write("The average of the inputed sequence of numbers is: ");
                CalculateAverage(numbers);
                break;
            case 3:
                Console.WriteLine("You have selected: 3 - To solve a linear equation");
                Console.WriteLine("Example -> a * x + b = 0");
                Console.Write("Enter the value for \"a\": ");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.Write("Enter the value for \"b\": ");
                decimal b = decimal.Parse(Console.ReadLine());
                while (a == 0)
                {
                    Console.WriteLine("\"a\" must not be equal to zero, enter different value:");
                    a = decimal.Parse(Console.ReadLine());
                }
                SolveLinearEquation(a, b);
                break;
            default:
                Console.WriteLine("There is no task with this number");
                break;
        }
    }
}