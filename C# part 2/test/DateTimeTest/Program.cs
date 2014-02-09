using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = new DateTime(2014, 1, 1, 0, 20, 0);
            DateTime next = new DateTime(2014, 1, 1, 02, 05, 00);
            Console.WriteLine(next.Subtract(start));
        }
    }
}
