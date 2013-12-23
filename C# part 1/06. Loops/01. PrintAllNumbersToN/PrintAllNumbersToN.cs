using System;

class PrintAllNumbersToN
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
            Console.WriteLine(i);
        }
    }
}