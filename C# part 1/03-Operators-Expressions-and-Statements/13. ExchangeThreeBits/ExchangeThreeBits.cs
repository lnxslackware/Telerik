using System;

class ExchangeThreeBits
{
    static void Main()
    {
        Console.Write("Enter the uint number: ");
        string userInput = Console.ReadLine();
        uint selectedNumber = uint.Parse(userInput);

        Console.WriteLine("The binary representation of the original value is:");
        Console.WriteLine(Convert.ToString(selectedNumber, 2));

        //our mask will be 7 (111 in binary)
        uint mask = 7;

        //here are the bits number 3, 4 and 5
        uint firstThreeBits = selectedNumber >> 3;
        firstThreeBits = firstThreeBits & mask;
        
        //here are the bits number 24, 25 and 26
        uint secondThreeBits = selectedNumber >> 24;
        secondThreeBits = secondThreeBits & mask;

        //we set a new mask value
        mask = firstThreeBits ^ secondThreeBits;

        //we set the new values of the bits number 3, 4, and 5
        mask = mask << 3;
        selectedNumber = selectedNumber ^ mask;

        //we set the new values of the bits number 24, 25 and 26
        mask = mask << 21;
        selectedNumber = selectedNumber ^ mask;

        Console.WriteLine("The binary representation of the new value is:");
        Console.WriteLine(Convert.ToString(selectedNumber, 2));
    }
}