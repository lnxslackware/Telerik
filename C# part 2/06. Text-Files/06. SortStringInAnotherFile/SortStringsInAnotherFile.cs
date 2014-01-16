using System;
using System.IO;
using System.Collections.Generic;

class SortStringsInAnotherFile
{
    static void Main()
    {
        string sourceFile = "../../unsorted.txt";
        string outputFile = "../../sorted.txt";
        List<string> stringsFromFile = new List<string>();
        string readedLine = string.Empty;

        StreamReader reader = new StreamReader(sourceFile);

        using (reader)
        {
            while ((readedLine = reader.ReadLine()) != null)
            {
                //We add all the lines to a List
                stringsFromFile.Add(readedLine);
            }
        }

        //Sort the list
        stringsFromFile.Sort();

        StreamWriter writer = new StreamWriter(outputFile);

        using (writer)
        {
            //Write all the elements of the sorted List into the output file
            foreach (var str in stringsFromFile)
            {
                writer.WriteLine(str);
            }
        }
    }
}