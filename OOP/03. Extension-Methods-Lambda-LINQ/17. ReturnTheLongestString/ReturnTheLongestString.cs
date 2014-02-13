/*
 * Write a program to return the string with maximum length from an array of strings. Use LINQ.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTheLongestString
{
    class ReturnTheLongestString
    {
        static void Main()
        {
            string[] words = 
            {
                "fasgsagas",
                "jgiasjpogsa",
                "jfpasp",
                "gasgsagasgagagasgsa",
                "jpojpohphfwoifhosahpfshapfhpsa",
                "gasdgsa"
            };

            var longest =
                (from word in words
                 select word).Max();

            Console.WriteLine("The longest word is: {0}", longest);
        }
    }
}
