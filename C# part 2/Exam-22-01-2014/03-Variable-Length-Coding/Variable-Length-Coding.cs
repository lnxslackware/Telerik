using System;
using System.Collections.Generic;
using System.Text;

class VariableLengthCoding
{

    static string StripMessage(string[] message, Dictionary<string, char> codeTable)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < message.Length; i++)
        {
            message[i] = Convert.ToString(int.Parse(message[i]), 2);
        }

        //OLD WRONG
        //foreach (var word in message)
        //{
        //    sb.Append(word);
        //}

        for (int i = 0; i < message.Length; i++)
        {
            sb.Append(message[i].PadLeft(8, '0'));
        }

        string result = DecryptPartOfMessage(sb.ToString(), codeTable);
        return result;
    }

    static string DecryptPartOfMessage(string partOfMessage, Dictionary<string, char> codeTable)
    {
        StringBuilder part = new StringBuilder();
        string[] letters = partOfMessage.TrimEnd('0').Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries);

        //TESTING




        //END OF TESTING

        //string stringToAppend = string.Empty;

        foreach (var letter in letters)
        {
            //if (codeTable.ContainsKey(new string('1', letter.Length)))
            //{
            part.Append(codeTable[new string('1', letter.Length)]);
            //}
        }
        return part.ToString();
    }

    static void Main()
    {
        //INPUT
        string[] message = Console.ReadLine().Split(' ');

        Dictionary<string, char> codeTable = new Dictionary<string, char>();
        int keysInCodeTable = int.Parse(Console.ReadLine());
        for (int i = 0; i < keysInCodeTable; i++)
        {
            string input = Console.ReadLine();
            char character = input[0];
            string digits = string.Empty;
            for (int j = 1; j < input.Length; j++)
            {
                digits += input[j];
            }
            codeTable.Add(new string('1', int.Parse(digits)), character);
        }

        Console.WriteLine(StripMessage(message, codeTable));
    }

}