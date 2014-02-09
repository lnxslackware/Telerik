namespace Generics
{
    using System;

    class Generics
    {
        static void Main()
        {

            //List test

            //creating an instance of the list
            GenericList<int> integerList = new GenericList<int>(4);

            //adding 5 elements
            for (int i = 0; i < 5; i++)
            {
                integerList.Add(i);
            }

            Console.WriteLine(integerList);

            //removing the element at position 3
            integerList.Remove(3);

            Console.WriteLine(integerList);

            //inserting element at position 3 with value 33
            integerList.Insert(3, 33);

            Console.WriteLine(integerList);

            //finding element by it's value
            Console.WriteLine(integerList.Find(33));

            //getting a value through the indexer
            Console.WriteLine(integerList[2]);

            //setting element through the indexer
            integerList[0] = 17;

            Console.WriteLine(integerList);

            //adding a single element at the end
            integerList.Add(7);

            Console.WriteLine(integerList);

            //get the minimal value from the list
            Console.WriteLine(integerList.Min<int>());

            //get the maximal value from the list
            Console.WriteLine(integerList.Max<int>());


            //Matrix test

            Matrix<int> firstMatrix = new Matrix<int>(2, 3);
            Matrix<int> secondMatrix = new Matrix<int>(2, 3);

            int numberToAdd = 1;

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    firstMatrix[i, j] = numberToAdd;
                    secondMatrix[i, j] = numberToAdd;
                    numberToAdd++;
                }
            }

            Console.WriteLine("first matrix: \r\n{0}", firstMatrix);
            Console.WriteLine("second matrix: \r\n{0}", secondMatrix);

            Matrix<int> summedMatrix = firstMatrix + secondMatrix;
            System.Console.WriteLine("Sum of the two matrices: \n{0}", summedMatrix);


            Matrix<int> subtractedMatrix = firstMatrix - secondMatrix;
            System.Console.WriteLine("Subtraction of the two matrices: \n{0}", subtractedMatrix);

            Matrix<int> thirdMatrix = new Matrix<int>(3, 2);

            numberToAdd = 1;

            for (int i = 0; i < thirdMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < thirdMatrix.GetLength(1); j++)
                {
                    thirdMatrix[i, j] = numberToAdd;
                    numberToAdd++;
                }
            }

            Matrix<int> multipliedMatrix = firstMatrix * thirdMatrix;
            System.Console.WriteLine("Multiplication of the two matrices: \n{0}", multipliedMatrix);

            if (firstMatrix)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }


    }
}
