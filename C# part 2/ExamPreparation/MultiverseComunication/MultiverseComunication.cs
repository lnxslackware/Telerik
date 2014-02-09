using System;

class MultiverseComunication
{
    static long Pow(int number, int pow)
    {
        long sum = 1;

        for (int i = 0; i < pow; i++)
        {
            sum *= number;
        }
        return sum;
    }

    static void Main()
    {
        string[] numbers = { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };

        string message = Console.ReadLine();

        long sum = 0;

        for (int i = message.Length - 3, j = 0; i >= 0; i -= 3, j++)
        {
            int index = Array.IndexOf(numbers, message.Substring(i, 3));
            sum += index * Pow(13, j);
        }

        Console.WriteLine(sum);
    }
}