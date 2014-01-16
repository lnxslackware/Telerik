using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceAllOccurrencesOfSubstringInFile
{
    static void Main()
    {
        string inputPath = "../../Textfile.txt";
        string outputPath = "../../tmp.txt";

        StreamReader reader = new StreamReader(inputPath);
        StreamWriter writer = new StreamWriter(outputPath);

        using (reader)
        {
            string readedLine = string.Empty;
            while ((readedLine = reader.ReadLine()) != null)
            {
                //writer.WriteLine(readedLine.Replace("start", "finish")); - Task 7
                writer.WriteLine(Regex.Replace(readedLine, @"\bstart\b", "finish")); // Task 8
            }
        }

        writer.Close();
        File.Delete(inputPath);
        File.Move(outputPath, inputPath);
    }
}