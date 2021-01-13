using System;

class Program
{
    static string VectorToString(double[] vector)
    {
        int i;
        string output = "(";
        for (i = 0; i < vector.Length - 1; i++)
        {
            output += $"{vector[i]}, ";
        }
        output += $"{vector[i]})";
        return output;
    }
    static void Main(string[] args)
    {
        double[] vector1 = {98, 972};
        double scalar = 0.5;

        Console.WriteLine($"{scalar} * {VectorToString(vector1)}");
        Console.WriteLine($" = {VectorToString(VectorMath.Multiply(vector1, scalar))}");
        Console.WriteLine();

        double[] vector2 = {0, -16, 31};
        scalar = 4;

        Console.WriteLine($"{scalar} * {VectorToString(vector2)}");
        Console.WriteLine($" = {VectorToString(VectorMath.Multiply(vector2, scalar))}");
        Console.WriteLine();

        double[] vector3 = {0, -16, 31, 2};
        scalar = 4;

        Console.WriteLine($"{scalar} * {VectorToString(vector3)}");
        Console.WriteLine($" = {VectorToString(VectorMath.Multiply(vector3, scalar))}");
        Console.WriteLine();

        double[] vector4 = {31};
        scalar = 4;

        Console.WriteLine($"{scalar} * {VectorToString(vector4)}");
        Console.WriteLine($" = {VectorToString(VectorMath.Multiply(vector4, scalar))}");
        Console.WriteLine();
    }
}
