/*
 * Write a program that prints from given array of integers all numbers that are 
 * divisible by 7 and 3. Use the built-in extension methods and lambda expressions.
 * Rewrite the same with LINQ.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersDivisibleBy7And3
{
    class PrintNumbersDivisibleBy7And3
    {
        static void Main()
        {
            int[] numbers = 
            {
                17,
                3,
                7,
                21,
                46,
                232,
                53,
                644
            };

            //With lambda expressions
            var selection = numbers.Where(num => (num != 0) && (num % 3 == 0) && (num % 7 == 0)).Select(num => num);

            foreach (var num in selection)
            {
                Console.WriteLine(num);
            }

            //With LINQ
            selection =
                from num in numbers
                where (num != 0) && (num % 3 == 0) && (num % 7 == 0)
                select num;

            foreach (var num in selection)
            {
                Console.WriteLine(num);
            }
        }
    }
}
