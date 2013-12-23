using System;

class SandGlass
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int starsCount = count;

        for (int i = 1; i <= count; i++)
        {
            Console.Write(new string('.', (count - starsCount) / 2));
            for (int j = 1; j <= starsCount; j++)
            {
                Console.Write("*");
            }
            Console.Write(new string('.', (count - starsCount) / 2));
            if (i < (count / 2) + 1)
            {
                starsCount -= 2;
            }
            else
            {
                starsCount += 2;
            }
            Console.WriteLine();
        }
    }
}