using System;

/// <summary>MatrixMath Class</summary>
class MatrixMath
{
    /// <summary>Method that adds two matrices and returns the resulting matrix.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2
            && matrix2.GetLength(0) == 2 && matrix2.GetLength(1) == 2)
        {
            double[,] new_matrix = {{0, 0}, {0, 0}};
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    new_matrix[i, j] = matrix1[i, j] + matrix2[i, j]; 
            }
            return new_matrix;
        }
        else if (matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3
            && matrix2.GetLength(0) == 3 && matrix2.GetLength(1) == 3)
        {
            double[,] new_matrix = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    new_matrix[i, j] = matrix1[i, j] + matrix2[i, j]; 
            }
            return new_matrix;
        }
        else
            return new double[,] {{-1}};
    }
}
