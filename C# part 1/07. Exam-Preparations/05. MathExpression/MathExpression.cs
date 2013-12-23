using System;

class MathExpression
{
    static void Main()
    {
        double nIndex = double.Parse(Console.ReadLine());
        double mIndex = double.Parse(Console.ReadLine());
        double pIndex = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:0.000000}", ((Math.Pow(nIndex, 2) + (1 / (mIndex * pIndex) + 1337)) / (nIndex - 128.523123123 * pIndex)) + Math.Sin((int)mIndex % 180));
    }
}