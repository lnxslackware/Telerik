using System;
using System.IO;

class ConcatenateTwoTextFiles
{
    static void Main()
    {
        string firstFilePath = "../../textfile1.txt";
        string secondFilePath = "../../textfile2.txt";
        string targetFilePath = "../../ConcatenatedFile.txt";

        StreamReader firstReader = new StreamReader(firstFilePath);
        string firstFile = firstReader.ReadToEnd();
        firstReader.Close();

        StreamReader secondReader = new StreamReader(secondFilePath);
        string secondFile = secondReader.ReadToEnd();
        secondReader.Close();

        StreamWriter writer = new StreamWriter(targetFilePath);
        writer.Write(firstFile + "\r\n" + secondFile);
        writer.Close();

        Console.WriteLine("The two files are now concatenated.");
    }
}