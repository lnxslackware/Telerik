using System;

class DrunkenNumbers
{
    static void Main()
    {
        int rounds = int.Parse(Console.ReadLine());

        int lSum = 0;
        int rSum = 0;
        int digit = 0;

        for (int i = 0; i < rounds; i++)
        {
            int roundNumber = Math.Abs(int.Parse(Console.ReadLine()));
            string numberAsString = roundNumber.ToString();

            if (numberAsString.Length % 2 == 0)
            {
                for (int j = 0; j < numberAsString.Length / 2; j++)
                {
                    digit = Convert.ToInt32(numberAsString[j].ToString());
                    lSum += digit;
                }

                for (int j = (numberAsString.Length / 2); j < numberAsString.Length; j++)
                {
                    digit = Convert.ToInt32(numberAsString[j].ToString());
                    rSum += digit;
                }
            }
            else
            {
                for (int j = 0; j <= numberAsString.Length / 2; j++)
                {
                    digit = Convert.ToInt32(numberAsString[j].ToString());
                    lSum += digit;
                }

                for (int j = (numberAsString.Length / 2); j < numberAsString.Length; j++)
                {
                    digit = Convert.ToInt32(numberAsString[j].ToString());
                    rSum += digit;
                }
            }
        }

        if (rSum > lSum)
        {
            Console.WriteLine("V {0}", rSum - lSum);
        }
        else if (rSum < lSum)
        {
            Console.WriteLine("M {0}", lSum - rSum);
        }
        else
        {
            Console.WriteLine("No {0}", lSum + rSum);
        }
    }
}