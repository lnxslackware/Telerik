/*
 * Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
 * reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
 * Be sure to catch all possible exceptions and print user-friendly error messages.
 */

using System;
using System.IO;

class ReadAndPrintFileContent
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter full path to the selected file.");
            Console.Write("PATH: ");
            string absolutePath = Console.ReadLine();

            string fileContent = File.ReadAllText(@absolutePath);

            Console.WriteLine(fileContent);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("You have not entered a filepath.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("You have entered incorrect filepath.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The entered path is too long to proceed.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("One or more directories from the filepath are not found.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The specified file is not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("Input/Output error.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("The program has no permissions to read the file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method does not support reading this file.");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("The program in unauthorised to read the file");
        }
    }
}