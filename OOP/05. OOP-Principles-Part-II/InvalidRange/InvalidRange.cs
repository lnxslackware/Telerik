using System;

namespace InvalidRange
{
    class InvalidRange
    {
        static void Main()
        {
            Console.Write("Enter a number between 1 and 100:");
            int number = int.Parse(Console.ReadLine());
            if (number < 1 || number > 100)
            {
                throw new InvalidRangeException<int>("The value is out of range", 1, 100);                
            }

            Console.Write("Enter a datetime between 1.1.1980 and 31.12.2013:");
            DateTime date = DateTime.Parse(Console.ReadLine());

            if ((date < new DateTime(1980, 1, 1)) || (date > new DateTime(2013, 12, 31)))
            {
                throw new InvalidRangeException<DateTime>("The date is out of range", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
            }
        }
    }
}
