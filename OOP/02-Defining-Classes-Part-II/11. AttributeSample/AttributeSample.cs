using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample
{
    class AttributeSample
    {
        static void Main()
        {
            SampleClass.SampleMethod();
            Type type = typeof(SampleClass);
            object[] attributes = type.GetCustomAttributes(typeof(VersionAttribute), false);
            foreach (var version in attributes)
            {
                Console.WriteLine("Version {0}", version);
            }
        }
    }
}
