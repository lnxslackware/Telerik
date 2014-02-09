using System;
using System.Text;

class TRES4_Numbers
{
    static StringBuilder Translate(ulong number)
    {
        StringBuilder sb = new StringBuilder();
        string stringToInsert = string.Empty;

        if (number == 0)
        {
            return sb.Insert(0, "LON+");
        }

        while (number > 0)
        {
            int reminder = (int)(number % 9);
            number = number / 9;

            switch (reminder)
            {
                case 0:
                    stringToInsert = "LON+";
                    break;
                case 1:
                    stringToInsert = "VK-";
                    break;
                case 2:
                    stringToInsert = "*ACAD";
                    break;
                case 3:
                    stringToInsert = "^MIM";
                    break;
                case 4:
                    stringToInsert = "ERIK|";
                    break;
                case 5:
                    stringToInsert = "SEY&";
                    break;
                case 6:
                    stringToInsert = "EMY>>";
                    break;
                case 7:
                    stringToInsert = "/TEL";
                    break;
                case 8:
                    stringToInsert = "<<DON";
                    break;
            }
            sb.Insert(0, stringToInsert);
        }


        return sb;
    }

    static void Main()
    {
        ulong message = ulong.Parse(Console.ReadLine());
        Console.WriteLine(Translate(message));
    }
}