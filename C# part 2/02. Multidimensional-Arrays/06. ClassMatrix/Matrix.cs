using System;

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
        if (matrix1.Cols == matrix2.Rows)
        {
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
        }
        else
        {
            Console.WriteLine("The two matrices cannot be multiplied.");
            Console.WriteLine("the count of the columns of the first matrix must be equal to the count of the rows of the second matrix.");
        }

        return newMatrix;
    }
}
