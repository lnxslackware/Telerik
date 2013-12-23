using System;

class ChangeByUsersChoice
{
    static void Main()
    {
        Console.Write("Input your choice with letters(int, double or string): ");
        string userChoice = Console.ReadLine();

        Console.Write("Your new value is: ");

        switch (userChoice)
        {
            case "int":
                Console.Write("Input your integer value: ");
                int userIntNumber = int.Parse(Console.ReadLine());
                userIntNumber = userIntNumber + 1;
                Console.WriteLine(userIntNumber);
                break;
            case "double":
                Console.Write("Input your double value: ");
                double userDoubleNumber = double.Parse(Console.ReadLine());
                userDoubleNumber = userDoubleNumber + 1.0;
                Console.WriteLine(userDoubleNumber);
                break;
            case "string":
                Console.Write("Input your string: ");
                string userString = Console.ReadLine();
                userString = userString + "*";
                Console.WriteLine(userString);
                break;
            default:
                break;
        }
    }
}