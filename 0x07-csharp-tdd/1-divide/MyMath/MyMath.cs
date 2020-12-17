using System;

namespace MyMath
{
    /// <summary>Represents Mathematical Operations.</summary>
    public class Matrix
    {
        /// <summary>Method that divides all elements of a matrix.</summary>
        /// <param name="matrix">A matrix</param>
        /// <param name="num">A Integer which divides each element in matrix</param>
        /// <returns>A new matrix containing divided elements</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            if (matrix == null)
                return null;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i, j] / num;
                }
            }
            return matrix;
        }
    }
}
