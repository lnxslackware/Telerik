using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combinatorics
{
    class Program
    {
        static void Main()
        {
            int k = 3;
            int n = 5;

            int[] elements = new int[k];
            Variations(elements, 0, 1, n);
        }

        static void Variations(int[] arr, int index, int start, int stop)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(", ", arr));
            }
            else
            {
                for (int i = start; i <= stop; i++)
                {
                    arr[index] = i;
                    Variations(arr, index + 1, i + 1, stop);
                }
            }
        }
    }
}
