using System;
using System.IO;

class FindAreaWithMaxSum
{
    static long FindMaximalSumInMatrix(int[,] matrix)
    {
        long maxSum = long.MinValue;
        long currentSum = 0;

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                currentSum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            currentSum = 0;
        }

        return maxSum;
    }

    static int[,] ReadIntegerMatrixFromFile(string filepath)
    {
        StreamReader reader = new StreamReader(filepath);
        string readedLine = reader.ReadLine();
        int matrixSize = int.Parse(readedLine);
        int[,] matrix = new int[matrixSize, matrixSize];

        using (reader)
        {
            for (int i = 0; i < matrixSize; i++)
            {
                string[] numberStringAsArray = reader.ReadLine().Split(' ');

                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = int.Parse(numberStringAsArray[j]);
                }
            }
        }
        return matrix;
    }

    static void Main()
    {
        string filePath = "../../matrix.txt";
        string outputFile = "../../output.txt";

        int[,] matrix = ReadIntegerMatrixFromFile(filePath);

        long maximalSum = FindMaximalSumInMatrix(matrix);

        StreamWriter writer = new StreamWriter(outputFile);

        using (writer)
        {
            writer.WriteLine(maximalSum);
        }
    }
}