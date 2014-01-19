using System;
using System.Text;

class EncodeAndDecodeString
{
    static string EncodeOrDecodeString(string str, string cypher)
    {
        StringBuilder builder = new StringBuilder();
        
        for (int i = 0; i < str.Length; i++)
        {

            builder.Append((char)((int)str[i] ^ cypher[i % cypher.Length]));
        }

        return builder.ToString();
    }

    static void Main()
    {
        string inputString = "banani s pijami";
        string cypher = "123qaz";

        Console.WriteLine("Starting string: {0}", inputString);

        string encodedString = EncodeOrDecodeString(inputString, cypher);
        Console.WriteLine("Encoded string: {0}", encodedString);

        encodedString = EncodeOrDecodeString(encodedString, cypher);
        Console.WriteLine("Decoded string: {0}", encodedString);
    }
}