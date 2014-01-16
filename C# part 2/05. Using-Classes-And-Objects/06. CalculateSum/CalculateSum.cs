using System;

class CalculateSum
{
    static long ParseAndCalculate(string numbersAsString)
    {
        long sum = 0;
        string[] splitedNumbers = numbersAsString.Split(' ');

        for (int i = 0; i < splitedNumbers.Length; i++)
        {
            sum += long.Parse(splitedNumbers[i]);
        }

        return sum;
    }

    static void Main()
    {
        Console.Write("Enter the numbers separated with spaces: ");
        string inputString = Console.ReadLine();

        Console.WriteLine("{0} -> {1}", inputString, ParseAndCalculate(inputString));
    }
}