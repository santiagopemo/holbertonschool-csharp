using System;

/// <summary>VectorMath Class</summary>
class VectorMath
{
    /// <summary>Method that multiplies a vector and a scalar and returns the resulting vector</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2)
        {
            double[] res = new double[2];
            res[0] = vector[0] * scalar;
            res[1] = vector[1] * scalar;
            return res;
        }
        if (vector.Length == 3)
        {
            double[] res = new double[3];
            res[0] = vector[0] * scalar;
            res[1] = vector[1] * scalar;
            res[2] = vector[2] * scalar;
            return res;
        }
        return new double[] {-1};
    }
}
