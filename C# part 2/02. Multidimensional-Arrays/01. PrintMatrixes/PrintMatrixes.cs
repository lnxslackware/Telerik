/*
 * Write a program that fills and prints a matrix of size (n, n) as shown.
 * 
 * A)
 *  1  5  9 13          
 *  2  6 10 14
 *  3  7 11 15
 *  4  8 12 16
 * 
 * B)
 *  1  8  9 16
 *  2  7 10 15
 *  3  6 11 14
 *  4  5 12 13
 *  
 * C)
 *  7 11 14 16
 *  4  8 12 15
 *  2  5  9 13
 *  1  3  6 10
 *  
 * D)
 *  1 12 11 10
 *  2 13 16  9
 *  3 14 15  8
 *  4  5  6  7
 */

using System;
class PrintMatrixes
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, -4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int number = 1;

        //Matrix "A"
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = number;
                number++;
            }
        }

        //Print the matrix
        Console.WriteLine();
        Console.WriteLine("Matrix \"A\"");
        PrintMatrix(matrix);

        //Matrix "B"
        number = 1;
        int currentRow = 0;
        int currentCol = 0;
        string direction = "down";

        while (number <= n * n)
        {
            if (direction == "down")
            {
                if (currentRow == n - 1)//If we are on the last row we change the direction and the column
                {
                    direction = "up";
                    matrix[currentRow, currentCol] = number;
                    currentCol++;
                }
                else
                {
                    matrix[currentRow, currentCol] = number;
                    currentRow++;
                }
            }
            else
            {
                if (currentRow == 0)//If we are on the first row we change the direction and the column
                {
                    direction = "down";
                    matrix[currentRow, currentCol] = number;
                    currentCol++;
                }
                else
                {
                    matrix[currentRow, currentCol] = number;
                    currentRow--;
                }
            }
            number++;
        }

        //Print the matrix
        Console.WriteLine();
        Console.WriteLine("Matrix \"B\"");
        PrintMatrix(matrix);

        //Matrix "C"
        //Reset all values to 0
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = 0;
            }
        }

        //Set some variables for the new initialization
        number = 1;
        currentRow = n - 1;
        currentCol = 0;
        direction = "up";
        matrix[currentRow, currentCol] = number;
        number++;

        while (number <= n * n)
        {
            if (direction == "up")
            {
                while (matrix[currentRow, currentCol] > 0 && currentRow > 0)
                {
                    currentRow--;
                }
                if (matrix[currentRow, currentCol] > 0)
                {
                    while (matrix[currentRow, currentCol] > 0)
                    {
                        currentCol++;
                    }
                }
                if (matrix[currentRow, currentCol] == 0)
                {
                    direction = "down";
                }
            }
            if (direction == "down")
            {
                matrix[currentRow, currentCol] = number;
                if (currentRow < n - 1 && currentCol < n - 1)
                {
                    currentRow++;
                    currentCol++;
                }
                else
                {
                    while (currentCol > 0)
                    {
                        currentCol--;
                    }
                    direction = "up";
                }
            }
            number++;
        }

        //Print the matrix
        Console.WriteLine();
        Console.WriteLine("Matrix \"C\"");
        PrintMatrix(matrix);


        //Matrix "D"
        //Reset all values to 0
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = 0;
            }
        }

        //declaring some variables we will need
        number = 0;
        currentRow = 0;
        currentCol = 0;
        direction = "down";

        while (number < n * n)
        {
            while (direction == "down")
            {
                if (matrix[currentRow, currentCol] == 0)
                {
                    number++;
                    matrix[currentRow, currentCol] = number;
                    if (currentRow < n - 1)
                    {
                        currentRow++;
                    }
                    else
                    {
                        currentCol++;
                        direction = "right";
                    }
                }
                else
                {
                    currentRow--;
                    currentCol++;
                    direction = "right";
                }
            }

            while (direction == "right")
            {
                if (matrix[currentRow, currentCol] == 0)
                {
                    number++;
                    matrix[currentRow, currentCol] = number;
                    if (currentCol < n - 1)
                    {
                        currentCol++;
                    }
                    else
                    {
                        currentRow--;
                        direction = "up";
                    }
                }
                else
                {
                    currentCol--;
                    currentRow--;
                    direction = "up";
                }
            }

            while (direction == "up")
            {
                if (matrix[currentRow, currentCol] == 0)
                {
                    number++;
                    matrix[currentRow, currentCol] = number;
                    if (currentRow > 0)
                    {
                        currentRow--;
                    }
                    else
                    {
                        currentCol--;
                        direction = "left";
                    }
                }
                else
                {
                    currentRow++;
                    currentCol--;
                    direction = "left";
                }
            }

            while (direction == "left")
            {
                if (matrix[currentRow, currentCol] == 0)
                {
                    number++;
                    matrix[currentRow, currentCol] = number;
                    if (currentCol > 0)
                    {
                        currentCol--;
                    }
                    else
                    {
                        currentRow++;
                        direction = "down";
                    }
                }
                else
                {
                    currentCol++;
                    currentRow++;
                    direction = "down";
                }
            }
        }


        //Print the matrix
        Console.WriteLine();
        Console.WriteLine("Matrix \"D\"");
        PrintMatrix(matrix);
    }
}