using System;

class CalculateSum
{
    static void Main()
    {
        double oldSum = 1.0;
        double newSum = 0.0;
        double tempSum = 0.0;

        for (int i = 1; Math.Abs(oldSum - newSum) > 0.001; i++)
        {
            oldSum = tempSum;
            if (i == 1 || i % 2 == 0)
            {
                newSum = oldSum + (1.0 / i);
            }
            else
            {
                newSum = oldSum - (1.0 / i);
            }
            tempSum = newSum;
        }
        Console.WriteLine("Previous sum: {0}", oldSum);
        Console.WriteLine("Last sum: {0}", newSum);
        Console.WriteLine("Difference: {0}", oldSum - newSum);
    }
}