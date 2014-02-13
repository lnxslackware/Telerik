using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> arr)
        {
            dynamic sum = 0;

            foreach (var item in arr)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> arr)
        {
            dynamic product = 1;

            foreach (var item in arr)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> arr) where T : IComparable<T>
        {
            T min = arr.First();

            foreach (var item in arr)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> arr) where T : IComparable<T>
        {
            T max = arr.First();

            foreach (var item in arr)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static decimal Avarage<T>(this IEnumerable<T> arr)
        {
            dynamic sum = 0;
            decimal counter = 0.0M;

            foreach (var item in arr)
            {
                sum += (dynamic)item;
                counter++;
            }

            return sum / counter;
        }
    }
}
