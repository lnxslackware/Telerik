/*
 * We are given a matrix of strings of size N x M. 
 * Sequences in the matrix we define as sets of several neighbor elements located on the same line, 
 * column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.
 * 
 * Example:
 *   ha fifi   ho   hi
 *   fo   ha   hi   xx  -> ha, ha, ha
 *  xxx   ho   ha   xx
 *  
 *   s  qq   s
 *  pp  qq   s  -> s, s, s
 *  pp  qq   s
 */
using System;

class LongerSequenceOfEqualStrings
{
    static void Main()
    {
        Console.Write("Enter N (rows of the matrix): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M (columns of the matrix): ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        //Reading the matrix from the console
        Console.WriteLine("Enter elements(separated with spaces): ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Row {0}: ", i);
            string userInput = Console.ReadLine();
            string[] userInputAsArray = userInput.Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = userInputAsArray[j];
            }
        }

        //Declaring variables needed for the checks and for the output

        //for the cuurent check
        string previousElement = "";
        int horizontalCount = 1;
        int verticalCount = 1;
        int leftDiagonalCount = 1;
        int rightDiagonalCount = 1;

        //for the maximal found sequence
        int maxSequenceCount = 1;
        string maxSequenceDirection = "";
        int firstElementRow = 0;
        int firstElementCol = 0;


        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                previousElement = matrix[row, col];

                for (int i = 1; i < matrix.GetLength(1); i++)
                {
                    //Horizontal check
                    if (col + i < matrix.GetLength(1))
                    {
                        if (matrix[row, col + i] == previousElement)
                        {
                            horizontalCount++;
                            if (horizontalCount > maxSequenceCount)
                            {
                                maxSequenceCount = horizontalCount;
                                firstElementCol = col;
                                firstElementRow = row;
                                maxSequenceDirection = "horizontal";
                            }
                        }
                    }
                    //Right diagonal check
                    if (((col + i) < matrix.GetLength(1)) && ((row + i) < matrix.GetLength(0)))
                    {
                        if (matrix[row + i, col + i] == previousElement)
                        {
                            rightDiagonalCount++;
                            if (leftDiagonalCount > maxSequenceCount)
                            {
                                maxSequenceCount = rightDiagonalCount;
                                firstElementCol = col;
                                firstElementRow = row;
                                maxSequenceDirection = "right_diagonal";
                            }
                        }
                    }
                    //Vertical check
                    if (row + i < matrix.GetLength(0))
                    {
                        if (matrix[row + i, col] == previousElement)
                        {
                            verticalCount++;
                            if (verticalCount > maxSequenceCount)
                            {
                                maxSequenceCount = verticalCount;
                                firstElementCol = col;
                                firstElementRow = row;
                                maxSequenceDirection = "vertical";
                            }
                        }
                    }
                    //Left diagonal check
                    if (((col - i) > 0) && ((row + i) < matrix.GetLength(0)))
                    {
                        if (matrix[row + i, col - i] == previousElement)
                        {
                            leftDiagonalCount++;
                            if (leftDiagonalCount > maxSequenceCount)
                            {
                                maxSequenceCount = leftDiagonalCount;
                                firstElementCol = col;
                                firstElementRow = row;
                                maxSequenceDirection = "left_diagonal";
                            }
                        }

                    }
                }
                horizontalCount = 1;
                leftDiagonalCount = 1;
                verticalCount = 1;
                leftDiagonalCount = 1;
            }
        }

        //Output
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Maximal sequence's elements count: {0}", maxSequenceCount);
        Console.WriteLine("First member: matrix[{0}, {1}]", firstElementRow, firstElementCol);
        Console.Write("Elements -> ");
        switch (maxSequenceDirection)
        {
            case "horizontal":
                for (int i = firstElementCol; i < firstElementCol + maxSequenceCount; i++)
                {
                    Console.Write("{0} ", matrix[firstElementRow, i]);
                }
                break;
            case "vertical":
                for (int i = firstElementRow; i < firstElementRow + maxSequenceCount; i++)
                {
                    Console.Write("{0} ", matrix[i, firstElementCol]);
                }
                break;
            case "left_diagonal":
                for (int i = 0; i < maxSequenceCount; i++)
                {
                    Console.Write("{0} ", matrix[firstElementRow + i, firstElementCol - i]);
                }
                break;
            case "right_diagonal":
                for (int i = 0; i < maxSequenceCount; i++)
                {
                    Console.Write("{0} ", matrix[firstElementRow + i, firstElementCol + i]);
                }
                break;
            default:
                Console.WriteLine("Unexpected error");
                break;
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 20));
    }
}