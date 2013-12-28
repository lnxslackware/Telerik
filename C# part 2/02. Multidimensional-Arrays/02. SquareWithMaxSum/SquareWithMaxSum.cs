/*
 * Write a program that reads a rectangular matrix of size N x M and 
 * finds in it the square 3 x 3 that has maximal sum of its elements.
 */

using System;

class SquareWithMaxSum
{
    static void Main()
    {
        Console.Write("Enter N (rows of the matrix): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M (columns of the matrix): ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        //Reading the matrix from the console
        Console.WriteLine("Enter elements(separated with spaces): ");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("Row {0}: ", i);
            string userInput = Console.ReadLine();
            string[] userInputAsArray = userInput.Split(' ');
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = int.Parse(userInputAsArray[j]);
            }
        }

        //int[,] matrix =
        //{
        //{1, 2, 3, 4, 5, 6, 7, 0, 9},
        //{1, 2, 3, 4, 5, 6, 7, 8, 9},
        //{1, 9, 9, 30, 5, 6, 7, 8, 9},
        //{1, 2, 15, 4, 5, 6, 2, 8, 9},
        //{1, 2, 7, 4, 5, 6, 6, 0, 9},
        //{1, 2, 3, 4, 5, 6, 7, 1, 9}
        //};
        //
        //Sample matrix with result:  9 30 5
        //                           15  4 5
        //                            7  4 5
        //

        Console.Write("Enter square size: ");
        int squareSize = int.Parse(Console.ReadLine());//Square with custom size works :) 
        int maxSum = int.MinValue; //Max sum found
        int startingElementRow = 0; //Row of the starting element needed for the output
        int startingElementCol = 0; //Col of the starting element needed for the output
        int currentSum = 0; //Sum of the current elements

        //Reading all squares with the selected size
        for (int row = 0; row <= matrix.GetLength(0) - squareSize; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - squareSize; col++)
            {
                for (int squareRows = 0; squareRows < squareSize; squareRows++)
                {
                    for (int squareCols = 0; squareCols < squareSize; squareCols++)
                    {
                        //Adding all square element's values to the current sum
                        currentSum += matrix[row + squareRows, col + squareCols];
                    }
                }
                //Comparing the current sum with the previous found maximal sum
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startingElementRow = row;
                    startingElementCol = col;
                }
                currentSum = 0;
            }
        }
        
        //Printing all the elements from the square with maximal sum
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Maximal sum found: {0}", maxSum);
        Console.WriteLine("Square:");

        for (int i = startingElementRow; i < startingElementRow + squareSize; i++)
        {
            for (int j = startingElementCol; j < startingElementCol + squareSize ; j++)
            {
                Console.Write("{0, -4} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}