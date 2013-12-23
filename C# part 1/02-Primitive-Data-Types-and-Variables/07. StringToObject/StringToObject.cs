using System;

class StringToObject
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object helloWorldObject = firstString + " " + secondString;
        string helloWorldString = (string)helloWorldObject;

        Console.WriteLine(helloWorldString);
    }
}
