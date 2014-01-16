using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;

class RemoveListedWords
{
    static void RemoveWordsInFile(string sourcePath, string wordlistPath)
    {
        List<string> replacedLines = new List<string>();

        StreamReader sourceReader = new StreamReader(sourcePath);

        List<string> wordList = WordList(wordlistPath);

        using (sourceReader)
        {
            string readedLine = string.Empty;

            while ((readedLine = sourceReader.ReadLine()) != null)
            {
                foreach (string wordToRemove in wordList)
                {
                    readedLine = Regex.Replace(readedLine, wordToRemove, "");
                }

                replacedLines.Add(readedLine);
            }
        }

        WriteChangesToFile(sourcePath, replacedLines);
    }

    static List<string> WordList(string wordlistPath)
    {
        List<string> wordlist = new List<string>();

        StreamReader wordlistReader = new StreamReader(wordlistPath);

        using (wordlistReader)
        {
            string readedLine = string.Empty;

            while ((readedLine = wordlistReader.ReadLine()) != null)
            {
                wordlist.Add(readedLine);
            }
        }

        return wordlist;
    }

    static void WriteChangesToFile(string targetFilePath, List<string> lines)
    {
        StreamWriter writer = new StreamWriter(targetFilePath);

        using (writer)
        {
            foreach (string line in lines)
            {
                writer.WriteLine(line);
            }
        }
    }

    static void Main()
    {
        string targetFilePath = "../../SourceFile.txt";
        string wordlistFilePath = "../../Wordlist.txt";
        try
        {
            RemoveWordsInFile(targetFilePath, wordlistFilePath);
        }
        catch (FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
            Console.WriteLine(exc.StackTrace);
        }
        catch (DirectoryNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
            Console.WriteLine(exc.StackTrace);
        }
        catch (ArgumentNullException exc)
        {
            Console.WriteLine(exc.Message);
            Console.WriteLine(exc.StackTrace);
        }
        catch (ArgumentException exc)
        {
            Console.WriteLine(exc.Message);
            Console.WriteLine(exc.StackTrace);
        }
        catch (OutOfMemoryException exc)
        {
            Console.WriteLine(exc.Message);
            Console.WriteLine(exc.StackTrace);
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.Message);
            Console.WriteLine(exc.StackTrace);
        }
    }
}