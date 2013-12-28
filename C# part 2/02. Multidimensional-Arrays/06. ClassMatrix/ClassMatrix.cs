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

class Matrix
{
    private int[,] matrix;
    private int rowsIndexes;
    private int colsIndexes;

    //Indexer
    public int this[int row, int col]
    {
        get
        {
            if ((row >= 0 && row < this.matrix.GetLength(0)) && (col >= 0 && col < this.matrix.GetLength(1)))
            {
                return this.matrix[row, col];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        set
        {
            if ((row >= 0 && row < this.matrix.GetLength(0)) && (col >= 0 && col < this.matrix.GetLength(1)))
            {
                this.matrix[row, col] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    private int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }

    private int Cols
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
        this.rowsIndexes = rows;
        this.colsIndexes = cols;
    }

    public override string ToString()
    {
        string returnString = "";

        for (int rows = 0; rows < this.matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < this.matrix.GetLength(1); cols++)
            {
                returnString += this.matrix[rows, cols] + " ";
            }
            returnString += "\n";
        }

        return returnString;
    }

    public static Matrix operator +(Matrix matrix1, Matrix matrix2)
    {
        Matrix newMatrix = new Matrix(matrix1.Rows, matrix1.Cols);

        for (int rows = 0; rows < matrix1.Rows; rows++)
        {
            for (int cols = 0; cols < matrix1.Cols; cols++)
            {
                newMatrix[rows, cols] = matrix1[rows, cols] + matrix2[rows, cols];
            }
        }

        return newMatrix;
    }

    public static Matrix operator -(Matrix matrix1, Matrix matrix2)
    {
        Matrix newMatrix = new Matrix(matrix1.Rows, matrix1.Cols);

        for (int rows = 0; rows < matrix1.Rows; rows++)
        {
            for (int cols = 0; cols < matrix1.Cols; cols++)
            {
                newMatrix[rows, cols] = matrix1[rows, cols] - matrix2[rows, cols];
            }
        }

        return newMatrix;
    }

    //Not sure multiplication working with matrices different than quadratic
    public static Matrix operator *(Matrix matrix1, Matrix matrix2)
    {
        Matrix newMatrix = new Matrix(matrix1.Rows, matrix2.Cols);
        int sum = 0;

        for (int newMatrixCols = 0; newMatrixCols < newMatrix.Cols; newMatrixCols++)
        {
            for (int newMatrixRows = 0; newMatrixRows < newMatrix.Rows; newMatrixRows++)
            {
                for (int i = 0; i < matrix1.Cols; i++)
                {
                    int element1 = matrix1[newMatrixRows, i];
                    int element2 = matrix2[i, newMatrixCols];
                    sum = element1 * element2;
                    newMatrix[newMatrixRows, newMatrixCols] += sum;
                }
            }
        }

        return newMatrix;
    }
}