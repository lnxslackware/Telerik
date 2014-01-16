using System;
using System.IO;

class CompareTwoFiles
{
    static void Main()
    {
        string firstFilePath = "../../FirstFile.txt";
        string secondFilePath = "../../SecondFile.txt";
        int equalLines = 0;
        int differentLines = 0;
        string readedLine = string.Empty;

        StreamReader firstReader = new StreamReader(firstFilePath);
        StreamReader secondReader = new StreamReader(secondFilePath);

        while ((readedLine = firstReader.ReadLine()) != null)
        {
            if (readedLine == secondReader.ReadLine())
            {
                equalLines++;
            }
            else
            {
                differentLines++;
            }
        }

        firstReader.Close();
        secondReader.Close();

        Console.WriteLine("There are {0} equal and {1} different lines in the two files", equalLines, differentLines);
    }
}