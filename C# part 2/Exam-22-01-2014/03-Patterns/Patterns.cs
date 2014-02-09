using System;
class Patterns
{

    static long CheckPatternsSum(int[,] matrix)
    {
        long maxSum = int.MinValue;
        long currentSum = 0;

        for (int i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for (int j = 0; j <= matrix.GetLength(1) - 5; j++)
            {
                if (CheckIfPatternValid(matrix, i, j))
                {
                    currentSum = GetSum(matrix, i, j);

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
        }

        return maxSum;
    }

    static long GetSum(int[,] matrix, int row, int col)
    {
        long sum = 0;

        sum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2] + matrix[row + 2, col + 3] + matrix[row + 2, col + 4];

        return sum;
    }

    static bool CheckIfPatternValid(int[,] matrix, int row, int col)
    {

        if ((matrix[row, col] + 1 != matrix[row, col + 1]) || (matrix[row, col + 1] + 1 != matrix[row, col + 2]) ||
            (matrix[row, col + 2] + 1 != matrix[row + 1, col + 2]) || (matrix[row + 1, col + 2] + 1 != matrix[row + 2, col + 2]) ||
            (matrix[row + 2, col + 2] + 1 != matrix[row + 2, col + 3]) || (matrix[row + 2, col + 3] + 1 != matrix[row + 2, col + 4]))
        {
            return false;
        }


        return true;
    }

    static long GetDiagonalSum(int[,] matrix)
    {
        long sum = 0;
        int row = 0;
        int col = 0;

        while (row < matrix.GetLength(0) && col < matrix.GetLength(1))
        {
            sum += matrix[row, col];
            row++;
            col++;
        }

        return sum;
    }

    static void Main()
    {
        //INPUT

        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < input.Length; j++)
            {
                matrix[i, j] = int.Parse(input[j]);
            }
        }
        
        //check the patterns

        long result = CheckPatternsSum(matrix);

        if (result > int.MinValue)
        {
            Console.WriteLine("YES {0}", result);
        }
        else
        {
            result = GetDiagonalSum(matrix);
            Console.WriteLine("NO {0}", result);
        }
    }
}