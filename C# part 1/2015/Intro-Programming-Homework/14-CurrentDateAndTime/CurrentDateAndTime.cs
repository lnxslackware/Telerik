/*
 * Create a console application that prints the current date and time. Find out how in Internet.
 */

namespace _14_CurrentDateAndTime
{
    using System;

    class CurrentDateAndTime
    {
        static void Main()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The date and time now is: {0}", currentTime);
        }
    }
}