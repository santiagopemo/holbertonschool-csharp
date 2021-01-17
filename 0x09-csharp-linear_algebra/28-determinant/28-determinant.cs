﻿using System;

/// <summary>MatrixMath Class</summary>
class MatrixMath
{
    /// <summary>Method that calculates the determinant of a matrix</summary>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            return Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1], 2);
        }
        if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            return Math.Round(matrix[0, 0] * matrix[1, 1] * matrix[2, 2]
                            + matrix[0, 1] * matrix[1, 2] * matrix[2, 0]
                            + matrix[0, 2] * matrix[1, 0] * matrix[2, 1]
                            - matrix[2, 0] * matrix[1, 1] * matrix[0, 2]
                            - matrix[2, 1] * matrix[1, 2] * matrix[0, 0]
                            - matrix[2, 2] * matrix[1, 0] * matrix[0, 1], 2);
        }
        return -1;
    }
}
