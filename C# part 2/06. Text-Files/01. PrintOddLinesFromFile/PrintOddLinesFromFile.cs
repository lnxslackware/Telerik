using System;
using System.IO;

class PrintOddLinesFromFile
{
    static void Main()
    {
        string filePath = "../../text.txt";
        StreamReader reader = new StreamReader(filePath);
        string readedLine = string.Empty;
        int counter = 1;

        while ((readedLine = reader.ReadLine()) != null)
        {
            if (counter % 2 != 0)
            {
                Console.WriteLine(readedLine);
            }

            counter++;
        }

        reader.Close();
    }
}