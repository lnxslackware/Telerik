/*
 * Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    class IEnumerableExtensions
    {
        static void Main()
        {
            List<int> list = new List<int>();

            for (int i = 1; i < 5; i++)
            {
                list.Add(i);
            }

            Console.WriteLine("Sum: {0}", list.Sum<int>());

            Console.WriteLine("Product: {0}", list.Product<int>());

            Console.WriteLine("Min: {0}", list.Min<int>());

            Console.WriteLine("Max: {0}", list.Max<int>());

            Console.WriteLine("Avarage: {0}", list.Avarage<int>());
        }
    }
}