using System;

namespace BitArray64
{
    class BitArray64Test
    {
        static void Main()
        {
            BitArray64 test = new BitArray64(4324432);

            foreach (var bit in test)
            {
                Console.Write(bit);
            }
        }
    }
}