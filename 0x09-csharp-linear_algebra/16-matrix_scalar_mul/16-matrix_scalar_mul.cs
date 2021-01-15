using System;

/// <summary>MatrixMath Class</summary>
class MatrixMath
{
    /// <summary>Method that multiplies a matrix and a scalar and returns the resulting matrix</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double[,] new_matrix = {{0, 0}, {0, 0}};
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    new_matrix[i, j] = matrix[i, j] * scalar; 
            }
            return new_matrix;
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            double[,] new_matrix = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    new_matrix[i, j] = matrix[i, j] * scalar; 
            }
            return new_matrix;
        }
        else
            return new double[,] {{-1}};
    }
}
