using System;

class CoffeeVendingMachine
{
    static void Main()
    {
        int coinsInTray1 = int.Parse(Console.ReadLine());
        int coinsInTray2 = int.Parse(Console.ReadLine());
        int coinsInTray3 = int.Parse(Console.ReadLine());
        int coinsInTray4 = int.Parse(Console.ReadLine());
        int coinsInTray5 = int.Parse(Console.ReadLine());

        double amountInserted = double.Parse(Console.ReadLine());
        double drinkPrice = double.Parse(Console.ReadLine());

        double amountInTrays = (coinsInTray1 * 0.05) + (coinsInTray2 * 0.10) + (coinsInTray3 * 0.20) + (coinsInTray4 * 0.50) + (coinsInTray5 * 1.00);

        if (amountInserted < drinkPrice)
        {
            Console.WriteLine("More {0:F2}", drinkPrice - amountInserted);
        }
        else if (amountInTrays >= (amountInserted - drinkPrice))
        {
            Console.WriteLine("Yes {0:F2}", amountInTrays - (amountInserted - drinkPrice));
        }
        else if (amountInTrays < (amountInserted - drinkPrice))
        {
            Console.WriteLine("No {0:F2}", (amountInserted - drinkPrice) - amountInTrays);
        }
    }
}