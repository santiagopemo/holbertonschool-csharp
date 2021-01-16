using System;

/// <summary>MatrixMath Class</summary>
class MatrixMath
{
    /// <summary>Method that multiplies two matrices and returns the resulting matrix</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            double[,] new_matrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(1); i++)
            {
                for (int j = 0; j < matrix1.GetLength(0); j++)
                {
                    for (int x = 0; x < matrix2.GetLength(1); x++)
                    {
                        new_matrix[j, x] += matrix1[j, i] * matrix2[i, x];
                    }
                }
            }
            return new_matrix;
        }
        return new double[,] {{-1}};
    }
}
