using System;

class ValueExchange
{
    static void Main()
    {
        int firstInt = 5;
        int secondInt = 10;

        Console.WriteLine("The starting value of the first integer is: " + firstInt);
        Console.WriteLine("The starting value of the first integer is: " + secondInt);

        firstInt = firstInt + secondInt;
        secondInt = firstInt - secondInt;
        firstInt = firstInt - secondInt;

        Console.WriteLine("The value of the first integer now is: " + firstInt);
        Console.WriteLine("The value of the second integer now is: " + secondInt);
    }
}