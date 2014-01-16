using System;
using System.IO;

class AddNumbersToTheLines
{
    static void Main()
    {
        string sourcePath = "../../Samplefile.txt";
        string targetPath = "../../NumberedLinesFile.txt";
        string readedLine = string.Empty;
        int counter = 1;

        StreamReader reader = new StreamReader(sourcePath);
        StreamWriter writer = new StreamWriter(targetPath);

        while ((readedLine = reader.ReadLine()) != null)
        {
            writer.WriteLine("{0}: {1}", counter, readedLine);
            counter++;
        }

        reader.Close();
        writer.Close();
    }
}