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
        double[] vector1 = {8, 11};
        double[] vector2 = {-4, 9};

        Console.WriteLine($"{VectorToString(vector1)} + {VectorToString(vector2)}");
        Console.WriteLine($"{VectorToString(VectorMath.Add(vector1, vector2))}");

        double[] vector3 = {14, -2, 0};
        double[] vector4 = {-3, 23, 50};

        Console.WriteLine($"{VectorToString(vector3)} + {VectorToString(vector4)}");
        Console.WriteLine($"{VectorToString(VectorMath.Add(vector3, vector4))}");

        Console.WriteLine($"{VectorToString(vector2)} + {VectorToString(vector4)}");
        Console.WriteLine($"{VectorToString(VectorMath.Add(vector2, vector4))}");

        double[] vector5 = {14, -2, 0, 2};
        double[] vector6 = {-3, 23, 50, 9};

        Console.WriteLine($"{VectorToString(vector5)} + {VectorToString(vector6)}");
        Console.WriteLine($"{VectorToString(VectorMath.Add(vector5, vector6))}");

        double[] vector7 = {14};
        double[] vector8 = {-3};

        Console.WriteLine($"{VectorToString(vector7)} + {VectorToString(vector8)}");
        Console.WriteLine($"{VectorToString(VectorMath.Add(vector7, vector8))}");        
    }
}
