using System;

class FloatOrDouble
{
    static void Main()
    {
        double firstDouble = 34.567839023;
        float firstFloat = 12.345F;
        double secondDouble = 8923.1234857;
        float secondFloat = 3456.091F;

        Console.WriteLine("{0} and {1} are doubles", firstDouble, secondDouble);
        Console.WriteLine("{0} and {1} are floats", firstFloat, secondFloat);
    }
}
