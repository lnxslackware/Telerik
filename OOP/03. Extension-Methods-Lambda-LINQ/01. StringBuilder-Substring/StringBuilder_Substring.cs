/*
 * Implement an extension method Substring(int index, int length) for 
 * the class StringBuilder that returns new StringBuilder and has the same
 * functionality as Substring in the class String.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Substring
{
    class StringBuilder_Substring
    {
        static void Main()
        {
            StringBuilder test = new StringBuilder("Loren impsum il doloris");
            Console.WriteLine(test);

            StringBuilder test2 = test.Substring(3, 6);
            Console.WriteLine(test2);
        }
    }
}
