using System;
using System.IO;

class ReadAndPrintFileContent
{
    static void Main()
    {
        Console.WriteLine("Enter full path to the selected file.");
        Console.Write("PATH: ");
        string absolutePath = Console.ReadLine();

        string fileContent = File.ReadAllText(absolutePath);
    }
}