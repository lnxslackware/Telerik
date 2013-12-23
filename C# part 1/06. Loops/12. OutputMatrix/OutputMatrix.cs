using System;

class OutputMatrix
{
    static void Main()
    {
        int userNumber;

        do
        {
            Console.Write("How many columns and rows do you want? (must be less than 20): ");
        }
        while (!int.TryParse(Console.ReadLine(), out userNumber));

        if (userNumber > 0 && userNumber < 20)
        {
            for (int i = 0; i < userNumber; i++)
            {
                Console.Write("|");
                for (int j = 1; j <= userNumber; j++)
                {
                    Console.Write("{0, 2}|", i + j);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("The number must be less than 20 and greater than 0!");
        }
    }
}