/*
 * Write a program that reads an integer number and calculates and prints its square root. 
 * If the number is invalid or negative, print "Invalid number". 
 * In all cases finally print "Good bye". Use try-catch-finally.
 */

using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the number: ");
            string inputedString = Console.ReadLine();

            if (inputedString == string.Empty)
            {
                throw new ArgumentNullException();
            }

            int number = 0;
            bool isNumber = int.TryParse(inputedString, out number);

            if (isNumber == false)
            {
                throw new FormatException();
            }

            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            double squareRoot = Math.Sqrt(number);

            Console.WriteLine("The square root of the number {0} is {1}", number, squareRoot);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("You have not inputed anything.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("You must enter a positive number");
        }
        catch (FormatException)
        {
            Console.WriteLine("You have not inputed an integer number(Type Int32).");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}