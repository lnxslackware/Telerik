using System;

class CheckIfSumIsZero
{
    static void Main()
    {
        int[] inputedNumbers = new int[5];
        int selectedNumberIndex = 0;
        string userInput;
        bool result = false;
        int sum = 0;


        Console.WriteLine("Please enter {0} numbers:", inputedNumbers.Length);
        do
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            selectedNumberIndex++;

        }
        while (int.TryParse(userInput, out inputedNumbers[selectedNumberIndex - 1]) && selectedNumberIndex < inputedNumbers.Length);

        foreach (int number in inputedNumbers)
        {
            if (number == sum)
            {
                Console.WriteLine("{0} = {0}", number, sum);
            }
        }

        for (int i = 0; i < inputedNumbers.Length; i++)
        {
            for (int j = 0; j < inputedNumbers.Length; j++)
            {
                if (inputedNumbers[i] + inputedNumbers[j] == sum && i > j)
                {
                    Console.WriteLine("{0} + {1} = {2}", inputedNumbers[i], inputedNumbers[j], sum);
                    result = true;
                }

                for (int k = 0; k < inputedNumbers.Length; k++)
                {
                    if (inputedNumbers[i] + inputedNumbers[j] + inputedNumbers[k] == sum && i > j && j > k)
                    {
                        Console.WriteLine("{0} + {1} + {2} = {3}", inputedNumbers[i], inputedNumbers[j], inputedNumbers[k], sum);
                        result = true;
                    }

                    for (int l = 0; l < inputedNumbers.Length; l++)
                    {
                        if (inputedNumbers[i] + inputedNumbers[j] + inputedNumbers[k] + inputedNumbers[l] == sum && i > j && j > k && k > l)
                        {
                            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", inputedNumbers[i], inputedNumbers[j], inputedNumbers[k], inputedNumbers[l], sum);
                            result = true;
                        }
                    }
                }
            }
        }
        if (inputedNumbers[0] + inputedNumbers[1] + inputedNumbers[2] + inputedNumbers[3] + inputedNumbers[4] == sum)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", inputedNumbers[0], inputedNumbers[1], inputedNumbers[2], inputedNumbers[3], inputedNumbers[4], sum);
            result = true;
        }
        if (result == false)
        {
            Console.WriteLine("There are no numbers, whitch sum = {0}", sum);
        }
    }
}