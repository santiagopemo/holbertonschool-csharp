using System;

/// <summary>VectorMath Class</summary>
class VectorMath
{
    /// <summary>Method that adds two vectors and returns the resulting vector</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] res = new double[2];
            res[0] = vector1[0] + vector2[0];
            res[1] = vector1[1] + vector2[1];
            return res;
        }
        if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] res = new double[3];
            res[0] = vector1[0] + vector2[0];
            res[1] = vector1[1] + vector2[1];
            res[2] = vector1[2] + vector2[2];
            return res;
        }
        return new double[] {-1};
    }
}
