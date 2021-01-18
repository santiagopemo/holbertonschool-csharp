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
        double[] vector1 = {2, -2, 1};
        double[] vector2 = {-8, 8, -4};

        Console.Write($"{VectorToString(vector1)}\n\tCross\n{VectorToString(vector2)}\n");
        Console.WriteLine($"\t=\n{VectorToString(VectorMath.CrossProduct(vector1, vector2))}");
        Console.WriteLine("------------\n");

        double[] vector3 = {2, -2};
        double[] vector4 = {-8, 8, -4};

        Console.Write($"{VectorToString(vector3)}\n\tCross\n{VectorToString(vector4)}\n");
        Console.WriteLine($"\t=\n{VectorToString(VectorMath.CrossProduct(vector3, vector4))}");
        Console.WriteLine("------------\n");
    }
}