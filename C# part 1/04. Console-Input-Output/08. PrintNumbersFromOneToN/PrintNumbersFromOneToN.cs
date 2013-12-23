using System;

class PrintNumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Enter the selected number: ");
        int selectedNumber = int.Parse(Console.ReadLine());
        for (int i = 1; i <= selectedNumber; i++)
        {
            Console.WriteLine(i);   
        }
    }
}