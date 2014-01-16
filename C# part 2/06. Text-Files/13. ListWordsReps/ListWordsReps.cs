using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

class ListWordsReps
{
    static Dictionary<string, int> CountSelectedWordsInFile(string testfilePath, string wordsfilePath)
    {
        StreamReader reader = new StreamReader(testfilePath);
        List<string> words = ReadTestingWords(wordsfilePath);

        //Dictionary to store the results
        Dictionary<string, int> reps = new Dictionary<string, int>();

        //Initializing the dictionary with default values
        foreach (string keyword in words)
        {
            reps.Add(keyword, 0);
        }

        using (reader)
        {
            string readedLine = string.Empty;

            //For every line from the checked file we test for all the words in the words file
            while ((readedLine = reader.ReadLine()) != null)
            {
                foreach (string keyword in words)
                {
                    //We add to the dictionary the count of the found matches for the regular expression
                    reps[keyword] += Regex.Matches(readedLine, @"\b" + keyword + @"\b").Count;
                }
            }
        }

        return reps;
    }

    static List<string> ReadTestingWords(string wordsFilePath)
    {
        //Create a list to contain all the words from the word file
        List<string> words = new List<string>();
        StreamReader reader = new StreamReader(wordsFilePath);

        using (reader)
        {
            string readedLine = string.Empty;

            while ((readedLine = reader.ReadLine()) != null)
            {
                //Adding the words to the list
                words.Add(readedLine);
            }
        }

        return words;
    }

    static void SortAndWriteResultsInFile(Dictionary<string, int> wordsAndReps, string outputPath)
    {
        //Sorting the dictionary
        wordsAndReps = wordsAndReps.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);


        //Open the writer
        StreamWriter writer = new StreamWriter(outputPath);

        //Write the results to a file
        using (writer)
        {
            foreach (var item in wordsAndReps)
            {
                writer.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }

    static void Main()
    {
        string testfilePath = "../../test.txt";
        string wordsfilePath = "../../words.txt";
        string resultfilePath = "../../result.txt";

        try
        {
            Dictionary<string, int> reps = CountSelectedWordsInFile(testfilePath, wordsfilePath);
            SortAndWriteResultsInFile(reps, resultfilePath);

            Console.WriteLine("Words counted!");
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