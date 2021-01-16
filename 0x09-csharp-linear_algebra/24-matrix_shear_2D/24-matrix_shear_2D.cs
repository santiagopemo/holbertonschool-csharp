using System;

/// <summary>MatrixMath Class</summary>
class MatrixMath
{
    /// <summary>Method that shears a square 2D matrix by a given shear factor and returns the resulting matrix</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2 && (direction == 'x' || direction == 'y'))
        {
            double[,] newMatrix = new double[2, 2];            
            double[,] shearMatrix = {
                {1, 0},
                {0, 1}
            };
            if (direction == 'x')
                shearMatrix[1, 0] = factor;
            else
                shearMatrix[0, 1] = factor;
            

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    for (int x = 0; x < shearMatrix.GetLength(1); x++)
                    {
                        newMatrix[j, x] = Math.Round(newMatrix[j, x] + (matrix[j, i] * shearMatrix[i, x]), 2);
                    }
                }
            }
            return newMatrix;
        }
        return new double[,] {{-1}};
    }
}
