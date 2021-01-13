using System;

/// <summary>VectorMath Class</summary>
class VectorMath
{
    /// <summary>Method that calculates and returns the length of a given vector</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return -1;
        double res = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            res += Math.Pow(vector[i], 2);
        }
        return Math.Round(Math.Sqrt(res), 2);        
    }
}
