using System;
using System.IO;
using System.Collections.Generic;

class DeleteAllOddLines
{
    static void Main()
    {
        string filePath = "../../Textfile.txt";
        List<string> evenLines = new List<string>();
        StreamReader reader = new StreamReader(filePath);
        int counter = 1;

        using (reader)
        {
            string readedLine = string.Empty;
            while ((readedLine = reader.ReadLine()) != null)
            {
                if (counter % 2 == 0)
                {
                    evenLines.Add(readedLine);
                }
                counter++;
            }
        }

        StreamWriter writer = new StreamWriter(filePath);

        using (writer)
        {
            foreach (string line in evenLines)
            {
                writer.WriteLine(line);
            }
        }
    }
}