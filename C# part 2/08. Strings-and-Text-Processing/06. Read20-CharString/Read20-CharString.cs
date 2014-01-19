using System;

class Read20_CharString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        if (str.Length < 20)
        {
            str = str.PadRight(20, '*');
        }

        if (str.Length > 20)
        {
            str = str.Substring(0, 20);
        }

        Console.WriteLine(str);
    }
}