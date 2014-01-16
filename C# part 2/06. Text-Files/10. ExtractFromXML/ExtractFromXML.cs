using System;
using System.IO;
using System.Collections.Generic;

class ExtractFromXML
{
    static void Main()
    {
        string filePath = "../../file.txt";
        List<string> wordList = new List<string>();
        string wordFound = string.Empty;

        StreamReader reader = new StreamReader(filePath);

        using (reader)
        {
            string readedLine;

            //we read the file line by line
            while ((readedLine = reader.ReadLine()) != null)
            {
                //We do a check till the end of the readed line
                for (int i = 0; i < readedLine.Length - 1; i++)
                {
                    //if we get to a closing tag
                    if (readedLine[i] == '>')
                    {
                        int j = 1;
                        //We add chars until we found an opening tag
                        while (readedLine[i + j] != '<')
                        {
                            wordFound += readedLine[i + j];
                            j++;
                        }

                        //if we have found any characters(a.k.a. word between the closing and the opening tag) we add it to the list
                        if (wordFound.Length > 0)
                        {
                            wordList.Add(wordFound);
                            wordFound = string.Empty;
                        }
                    }
                }
            }
        }

        //Printing all the words we have found
        Console.WriteLine("All found words are:");

        foreach (string str in wordList)
        {
            Console.WriteLine(str);
        }
    }
}