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
        double[] vector1 = {1, 3};
        double[] vector2 = {-2, 5};

        Console.WriteLine($"{VectorToString(vector1)} * {VectorToString(vector2)}");
        Console.WriteLine($" = {VectorMath.DotProduct(vector1, vector2)}");

        double[] vector3 = {-4, 0, 10};
        double[] vector4 = {3, 7, -9};

        Console.WriteLine($"{VectorToString(vector3)} * {VectorToString(vector4)}");
        Console.WriteLine($" = {VectorMath.DotProduct(vector3, vector4)}");

        Console.WriteLine($"{VectorToString(vector2)} * {VectorToString(vector4)}");
        Console.WriteLine($" = {(VectorMath.DotProduct(vector2, vector4))}");

        double[] vector5 = {14, -2, 0, 2};
        double[] vector6 = {-3, 23, 50, 9};

        Console.WriteLine($"{VectorToString(vector5)} * {VectorToString(vector6)}");
        Console.WriteLine($" = {(VectorMath.DotProduct(vector5, vector6))}");

        double[] vector7 = {14};
        double[] vector8 = {-3};

        Console.WriteLine($"{VectorToString(vector7)} * {VectorToString(vector8)}");
        Console.WriteLine($" = {(VectorMath.DotProduct(vector7, vector8))}");        
    }
}