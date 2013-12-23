using System;

class DeclaringVariables
{
    static void Main()
    {
        ushort firstVariable = 52130;
        sbyte secondVariable = -115;
        int thirdVariable = 4825932;
        byte fourthVariable = 97;
        short fifthVariable = -10000;

        Console.WriteLine("The first variable is of type \"ushort\" and has the value " + firstVariable);
        Console.WriteLine("The second variable is of type \"sbyte\" and has the value " + secondVariable);
        Console.WriteLine("The third variable is of type \"int\" and has the value " + thirdVariable);
        Console.WriteLine("The fourth variable is of type \"byte\" and has the value " + fourthVariable);
        Console.WriteLine("The fifth variable is of type \"short\" and has the value " + fifthVariable);
    }
}

