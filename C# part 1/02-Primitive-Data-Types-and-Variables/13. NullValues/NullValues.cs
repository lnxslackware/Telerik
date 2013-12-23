using System;

class NullValues
{
    static void Main()
    {
        int? intVariable = null;
        double? doubleVariable = null;

        Console.WriteLine("Printing integer variable with a null value -> " + intVariable);
        Console.WriteLine("Printing double variable with a null value -> " + doubleVariable);

        intVariable = intVariable.GetValueOrDefault() + 234;
        doubleVariable = 34.56564434;

        Console.WriteLine("Printing integer variable with added integer value -> " + intVariable);
        Console.WriteLine("Printing integer variable with added double value -> " + doubleVariable);

        intVariable = intVariable + null;
        doubleVariable = doubleVariable + null;

        Console.WriteLine("Printing integer variable with added null value -> " + intVariable);
        Console.WriteLine("Printing double variable with added null value -> " + doubleVariable);
    }
}