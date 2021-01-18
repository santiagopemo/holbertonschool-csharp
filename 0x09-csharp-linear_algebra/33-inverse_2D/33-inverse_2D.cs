using System;

/// <summary>MatrixMath Class</summary>
class MatrixMath
{
    /// <summary>Method that calculates the inverse of a 2D matrix and returns the resulting matrix</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            if (determinant != 0)
            {
                double[,] inverse = {
                    {Math.Round(matrix[1, 1] / determinant, 2), Math.Round((-1) * matrix[0, 1] / determinant, 2)}, 
                    {Math.Round((-1) * matrix[1, 0] / determinant, 2), Math.Round(matrix[0, 0] / determinant, 2)}
                };
                return inverse;
            }
        }
        return new double[,] {{-1}};
    }
}

