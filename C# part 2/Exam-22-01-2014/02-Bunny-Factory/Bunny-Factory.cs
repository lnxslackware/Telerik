using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

class Bunny_Factory
{
    static StringBuilder ProcessFactory(List<string> cages, int cycle)
    {

        if (cycle > cages.Count)
        {
            return new StringBuilder("0");
        }

        int s = 0;
        int sum = 0;
        BigInteger product = 1;
        for (int i = 0; i < cycle; i++)
        {
            s += int.Parse(cages[i]);

            if (s > cages.Count)
            {
                return new StringBuilder("0");
            }
        }

        for (int i = cycle; i < cycle + s; i++)
        {
            int count = int.Parse(cages[i]);

            sum += count;
            product *= (ulong)count;
        }

        StringBuilder result = new StringBuilder(sum.ToString() + product.ToString());

        for (int i = cycle + s; i < cages.Count; i++)
        {
            result.Append(cages[i]);
        }

        EditList(cages, result);
        return result;
    }

    static void EditList(List<string> cages, StringBuilder newValues)
    {
        cages.Clear();

        for (int i = 0; i < newValues.Length; i++)
        {
            if (newValues[i] != '0' && newValues[i] != '1')
            {
                cages.Add(newValues[i].ToString());                
            }
        }
    }

    static void Main()
    {
        List<string> cages = new List<string>();
        string input = string.Empty;

        //READING
        while (true)
        {
            input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            cages.Add(input);
        }

        //process factory
        //string result = "";
        for (int i = 1; i < cages.Count; i++)
        {
            string newprocess = ProcessFactory(cages, i).ToString();
            if (newprocess == "0")
            {
                break;
            }
        }

        for (int i = 0; i < cages.Count; i++)
        {
            Console.Write(cages[i]);
            if (i != cages.Count - 1)
            {
                Console.Write(" ");
            }
        }

    }
}