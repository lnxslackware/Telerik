using System;

class PrintNotDivisibleBy3And7
{
    static void Main()
    {
        string userInput;
        int count;

        do
        {
            Console.Write("Whitch would be the last number to display?: ");
            userInput = Console.ReadLine();
        }
        while (!int.TryParse(userInput, out count));

        for (int i = 1; i <= count; i++)
        {
            if (!(i % 3 == 0 && i % 7 == 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}