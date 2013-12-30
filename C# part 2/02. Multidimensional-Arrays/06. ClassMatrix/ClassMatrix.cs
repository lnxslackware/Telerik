/*
 * * Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, 
 * subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
 */

using System;

class ClassMatrix
{
    static void ReadMatrixFromConsole(int rowsCount, int colsCount, out Matrix outMatrix)
    {
        outMatrix = new Matrix(rowsCount, colsCount);

        for (int row = 0; row < rowsCount; row++)
        {
            Console.Write("Row {0}: ", row);
            string userInput = Console.ReadLine();
            string[] splitedUserInput = userInput.Split(' ');
            for (int strings = 0; strings < colsCount; strings++)
            {
                outMatrix[row, strings] = int.Parse(splitedUserInput[strings]);
            }
        }
    }
    static void Main()
    {
        Console.Write("Enter number of rows for the matrices: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of cols for the matrices: ");
        int cols = int.Parse(Console.ReadLine());

        Matrix firstMatrix = new Matrix(rows, cols);
        Matrix secondMatrix = new Matrix(rows, cols);

        Console.WriteLine("Enter values to the first matrix(separated with single spaces):");
        ReadMatrixFromConsole(rows, cols, out firstMatrix);

        Console.WriteLine("Enter values to the second matrix(separated with single spaces):");
        ReadMatrixFromConsole(rows, cols, out secondMatrix);

        Console.Clear();
        Console.WriteLine("Your first matrix:");
        Console.WriteLine(firstMatrix.ToString());
        Console.WriteLine("Your second matrix:");
        Console.WriteLine(secondMatrix.ToString());

        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Result of operations: ");
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Adding:");
        Console.WriteLine(firstMatrix + secondMatrix);
        Console.WriteLine("Substraction:");
        Console.WriteLine(firstMatrix - secondMatrix);
        Console.WriteLine("Multiplication:");
        Console.WriteLine(firstMatrix * secondMatrix);
    }
}