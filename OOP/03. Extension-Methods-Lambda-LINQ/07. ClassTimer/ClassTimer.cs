using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTimer
{
    public class ClassTimer
    {
        public delegate void SimpleDelegate();
        public static void PrintLine()
        {
            Console.WriteLine("This text is displaying periodically.");
        }

        static void Main()
        {
            SimpleDelegate d = new SimpleDelegate(PrintLine);

            Timer timer = new Timer();
            timer.Start(d, 2);
        }
    }
}
