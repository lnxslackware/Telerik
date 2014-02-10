namespace Generics
{
    using System;
    using System.Text;

    class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private T[,] data;

        public Matrix(int rows, int cols)
        {
            data = new T[rows, cols];
        }

        public Matrix(T[,] matrix)
        {
            data = matrix;
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row > data.GetLength(0)) || ((col < 0) || col > data.GetLength(1)))
                {
                    throw new ArgumentOutOfRangeException("The given index is not in range of the matrix.");
                }

                return this.data[row, col];
            }

            set
            {
                if ((row < 0 || row > data.GetLength(0)) || ((col < 0) || col > data.GetLength(1)))
                {
                    throw new ArgumentOutOfRangeException("The given index is not in range of the matrix.");
                }

                this.data[row, col] = value;
            }
        }

        public int GetLength(int dimention)
        {
            if (dimention < 0 || dimention > 1)
            {
                throw new ArgumentOutOfRangeException("There is no such dimention in the matrix.");
            }

            return this.data.GetLength(dimention);
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.GetLength(0) != secondMatrix.GetLength(0)) || (firstMatrix.GetLength(1) != secondMatrix.GetLength(1)))
            {
                throw new InvalidOperationException("The two matrixes cannot be added.");
            }

            T[,] result = new T[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                }
            }

            return new Matrix<T>(result);
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.GetLength(0) != secondMatrix.GetLength(0)) || (firstMatrix.GetLength(1) != secondMatrix.GetLength(1)))
            {
                throw new InvalidOperationException("The two matrixes cannot be substracted.");
            }

            T[,] result = new T[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                }
            }

            return new Matrix<T>(result);
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.GetLength(1) != secondMatrix.GetLength(0)))
            {
                throw new InvalidOperationException("The two matrixes cannot be multiplied.");
            }

            T[,] result = new T[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
            T sum;

            for (int resultCols = 0; resultCols < result.GetLength(1); resultCols++)
            {
                for (int resultRows = 0; resultRows < result.GetLength(0); resultRows++)
                {
                    for (int i = 0; i < firstMatrix.GetLength(1); i++)
                    {
                        T element1 = firstMatrix[resultRows, i];
                        T element2 = secondMatrix[i, resultCols];
                        sum = (dynamic)element1 * (dynamic)element2;
                        result[resultRows, resultCols] += (dynamic)sum;
                    }
                }
            }

            return new Matrix<T>(result);
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] != (dynamic)default(T))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] != (dynamic)default(T))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.data.GetLength(0); row++)
            {
                for (int col = 0; col < this.data.GetLength(1); col++)
                {
                    result.Append(data[row, col]);

                    if (col != this.data.GetLength(1) - 1)
                    {
                        result.Append(" ");
                    }
                }

                if (row != this.data.GetLength(0) - 1)
                {
                    result.AppendLine();
                }
            }

            return result.ToString();
        }


    }
}
