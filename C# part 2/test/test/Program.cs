using System;
using System.IO;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.CursorVisible = false;

        for (int i = 1; i < 12; i++)
        {
            StreamReader reader = new StreamReader("Intro/" + i + ".txt");
            Console.WriteLine(reader.ReadToEnd());
            
            reader.Close();
            if (i == 11)
            {
                Thread.Sleep(3000);
            }
            else
            {
                Thread.Sleep(300);
            }
            
            Console.Clear();
        }
    }
}