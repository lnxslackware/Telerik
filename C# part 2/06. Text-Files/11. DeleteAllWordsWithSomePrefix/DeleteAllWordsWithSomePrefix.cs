using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class DeleteAllWordsWithSomePrefix
{
    static void Main()
    {
        string filePath = "../../Textfile.txt";
        StreamReader reader = new StreamReader(filePath);
        List<string> editedLines = new List<string>();

        using (reader)
        {
            string readedLine = string.Empty;

            while ((readedLine = reader.ReadLine()) != null)
            {
                editedLines.Add(Regex.Replace(readedLine, @"\btest[a-zA-Z0-9_]+\b", ""));
            }
        }

        StreamWriter writer = new StreamWriter(filePath);

        using (writer)
        {
            foreach (string line in editedLines)
            {
                writer.WriteLine(line);
            }
        }
    }
}