using System;

class Neurons
{
    static void Main()
    {
        int[] inputNumbers = new int[32];
        string input = "";
        int count = 0;
        int zeroCount = 0;
        int previousBit = 0;
        int bitPosition = 0;

        while (input != "-1")
        {
            input = Console.ReadLine();
            inputNumbers[count] = int.Parse(input);
            count++;
        }

        inputNumbers[count] = -1;

        for (int i = 0; i < inputNumbers.Length; i++)
        {
            if (inputNumbers[i] != -1)
            {
                for (int j = 0; j < 32; j++)
                {
                    int mask = 1 << j;
                    int bit = (inputNumbers[i] & mask) >> j;

                    if (bit == 1 && previousBit == 1)
                    {
                        previousBit = 1;
                        zeroCount = 0;
                        bitPosition = 0;
                    }
                    else if (bit == 0 && previousBit == 0)
                    {
                        previousBit = 0;
                        zeroCount++;
                    }
                    else if (bit == 1 && previousBit == 0)
                    {
                        previousBit = 1;
                        bitPosition = 0;
                        zeroCount = 0;
                    }
                    else // if (bit == 0 && previousBit == 1)
                    {
                        previousBit = 0;
                        bitPosition = j;
                        zeroCount++;
                    }

                    switch (zeroCount)
                    {
                        case 1:
                            mask = 1 << bitPosition;
                            break;
                        case 2:
                            mask = 3 << bitPosition;
                            break;
                        case 3:
                            mask = 7 << bitPosition;
                            break;
                        case 4:
                            mask = 15 << bitPosition;
                            break;
                        case 5:
                            mask = 31 << bitPosition;
                            break;
                        case 6:
                            mask = 63 << bitPosition;
                            break;
                        default:
                            break;
                    }

                    inputNumbers[i] = mask ^ inputNumbers[i];

                }
                Console.WriteLine(inputNumbers[i]);
            }
            else
            {
                break;
            }
        }


        //for (int i = 0; i < inputNumbers.Length; i++)
        //{
        //    if (inputNumbers[i] == -1)
        //    {
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine(inputNumbers[i]);
        //    }
        //}
    }

}