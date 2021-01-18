using System;

/// <summary>VectorMath Class</summary>
class VectorMath
{
    /// <summary>Method that calculates the cross product of two 3D vectors and returns the resulting vector</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] newVector = new double[3];

            newVector[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
            newVector[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
            newVector[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];
            return newVector;
        }
        return new double[] {-1};
    }
}
