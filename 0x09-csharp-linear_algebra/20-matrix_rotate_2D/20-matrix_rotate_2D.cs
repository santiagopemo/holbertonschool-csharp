using System;

/// <summary>MatrixMath Class</summary>
class MatrixMath
{
    /// <summary>Method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double[,] newMatrix = new double[2, 2];            
            double[,] rotationMatrix = {
                {Math.Cos(angle), Math.Sin(angle)},
                {-1 * Math.Sin(angle), Math.Cos(angle)}
            };

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    for (int x = 0; x < rotationMatrix.GetLength(1); x++)
                    {
                        newMatrix[j, x] = Math.Round(newMatrix[j, x] + (matrix[j, i] * rotationMatrix[i, x]), 2);
                    }
                }
            }
            return newMatrix;
        }
        return new double[,] {{-1}};
    }
}
