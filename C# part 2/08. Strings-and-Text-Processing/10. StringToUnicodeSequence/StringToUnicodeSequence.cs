using System;
using System.Text;

class StringToUnicodeSequence
{
    static void Main()
    {
        string sampleString = "Hi!";
        StringBuilder builder = new StringBuilder();
        foreach (char character in sampleString)
        {
            builder.Append(string.Format("\\u{0:X4}", (int)character));
        }

        sampleString = builder.ToString();

        Console.WriteLine("{0}", sampleString);
    }
}