using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class EPG_Generator
{
    //This method have to insert all durations to the file
    static void PrepareSourceFileWithDurations()
    {

    }

    static void InitializeNewFile(string xmlPath, string tvchannel)
    {
        StreamWriter writer = new StreamWriter(xmlPath);
        writer.WriteLine("<?xml version=\"1.0\" encoding=\"windows-1251\"?>\r\n<?xml-stylesheet type=\"text/xsl\" href=\"/epg.xsl\"?>\r\n<channel name=\"{0}\" lang=\"bul\" encoding=\"cyrillic\">", tvchannel);
        writer.Close();
    }

    static string GetNewFileName(string filename)
    {
        string[] convertFilename = filename.Split('/');
        string filePath = "../../EPG-" + convertFilename[1] + "-" + convertFilename[0] + "-" + convertFilename[2].Substring(0, 4) + ".xml";
        return filePath;
    }

    static void Main()
    {

        //TODO: Fix bug with 'AMELIA' on 01.01.2014
        Console.Title = "EPG XML Generator";
        Console.WriteLine("This program works with Excell files exported as Tab-Delimited .txt files.");
        Console.WriteLine();
        Console.WriteLine("What is the name of the TV channel? ");
        string tvchannel = Console.ReadLine();
        Console.WriteLine("Source file name: ");
        string sourcePath = @"../../" + Console.ReadLine();
        string xmlPath = "../../test.txt";
        string eventDate = string.Empty;
        string emptyValue = string.Empty;


        StreamReader reader = new StreamReader(sourcePath, Encoding.GetEncoding("windows-1251"));

        using (reader)
        {
            string line = string.Empty;
            
            //trying to find the character that is failing the parse
            //int newLineIndex = line.IndexOf('\n');

            //if (newLineIndex < line.Length - 1 && newLineIndex > 0)
            //{
            //    line = line.Remove(newLineIndex, 1);
            //}

            while ((line = reader.ReadLine()) != null)
            {
                string[] lineValues = line.Split('\t');//old -> \t

                StreamWriter writer = new StreamWriter(xmlPath, true);
                
                if (Regex.IsMatch(lineValues[0], @"^\d\d*/\d\d*/\d\d\d\d"))
                {
                    xmlPath = GetNewFileName(lineValues[0]);
                    string[] date = lineValues[0].Split(' ');
                    eventDate = date[0];
                    InitializeNewFile(xmlPath, tvchannel);
                    writer.WriteLine("</channel>");
                    writer.Close();
                }
                else
                {
                    if (lineValues[0] != string.Empty && lineValues.Length == 5) //<- bug workaround
                    {
                        writer.WriteLine("\t<event start=\"{0} {1}\" duration=\"{2}\">", eventDate, lineValues[0], lineValues[1]);
                        writer.WriteLine("\t\t<description>");
                        writer.WriteLine("\t\t\t<name>{0}</name>", lineValues[2]);
                        writer.WriteLine("\t\t\t<text>{0}></text>", lineValues[2]);
                        writer.WriteLine("\t\t</description>");
                        writer.WriteLine("\t\t<longdescription>");
                        writer.WriteLine("\t\t\t<text>{0} {1}</text>", lineValues[3], lineValues[4] == string.Empty ? string.Empty : "\n" + lineValues[4]);
                        writer.WriteLine("\t\t</longdescription>");
                        writer.WriteLine("\t</event>");
                    }

                    writer.Close();
                }
            }
        }

        Console.WriteLine("XML files generated");
    }
}