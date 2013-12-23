﻿/*
 * Write a program that fills and prints a matrix of size (n, n) as shown.
 */

using System;
class PrintMatrixes
{
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
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

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
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

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
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

    }
}