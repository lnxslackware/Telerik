using System;

class BonusScoreSystem
{
    static void Main()
    {
        Console.Write("Enter score (digit [1-9]): ");

        string userInput = Console.ReadLine();
        int userScore = 0;
        bool inputIsDigit = int.TryParse(userInput, out userScore);

        if (inputIsDigit)
        {
            switch (userScore)
            {
                case 0:
                    Console.WriteLine("The digit must be greater than 0!");
                    break;
                case 1:
                case 2:
                case 3:
                    userScore = userScore * 10;
                    Console.WriteLine("Your new value is {0}", userScore);
                    break;
                case 4:
                case 5:
                case 6:
                    userScore = userScore * 100;
                    Console.WriteLine("Your new value is {0}", userScore);
                    break;
                case 7:
                case 8:
                case 9:
                    userScore = userScore * 1000;
                    Console.WriteLine("Your new value is {0}", userScore);
                    break;
                default:
                    Console.WriteLine("You did not input a digit, but a number!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Wrong data type!");
        }
    }
}