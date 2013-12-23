using System;

class PrintAllCardNames
{
    static void Main()
    {
        string cardName = "";
        string[] cardColor = new string[] { " of spades", " of diamonds", " of heatrs", " of clubs" };


        for (int i = 1; i <= 13; i++)
        {
            switch (i)
            {
                case 1:
                    cardName = "Ace";
                    break;
                case 2:
                    cardName = "Two";
                    break;
                case 3:
                    cardName = "Three";
                    break;
                case 4:
                    cardName = "Four";
                    break;
                case 5:
                    cardName = "Five";
                    break;
                case 6:
                    cardName = "Six";
                    break;
                case 7:
                    cardName = "Seven";
                    break;
                case 8:
                    cardName = "Eight";
                    break;
                case 9:
                    cardName = "Nine";
                    break;
                case 10:
                    cardName = "Ten";
                    break;
                case 11:
                    cardName = "Jack";
                    break;
                case 12:
                    cardName = "Queen";
                    break;
                case 13:
                    cardName = "King";
                    break;
                default:
                    break;
            }

            for (int j = 0; j < cardColor.Length; j++)
            {
                Console.Write(cardName);
                Console.WriteLine(cardColor[j]);
            }
            Console.WriteLine();
        }

    }
}