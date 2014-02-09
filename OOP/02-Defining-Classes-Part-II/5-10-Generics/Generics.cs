namespace Generics
{
    using System;

    class Generics
    {
        static void Main()
        {
            GenericList<int> integerList = new GenericList<int>(4);

            for (int i = 0; i < 5; i++)
            {
                integerList.Add(i);
            }

            Console.WriteLine(integerList);

            integerList.Remove(3);

            Console.WriteLine(integerList);

            integerList.Insert(3, 33);

            Console.WriteLine(integerList);

            Console.WriteLine(integerList.Find(33));

            Console.WriteLine(integerList[2]);

            integerList[0] = 17;

            Console.WriteLine(integerList);

            integerList.Add(7);

            Console.WriteLine(integerList);

            Console.WriteLine(integerList.Min<int>());
            Console.WriteLine(integerList.Max<int>());
        }

        
    }
}
