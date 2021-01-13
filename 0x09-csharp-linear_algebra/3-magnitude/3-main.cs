using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = {3.0, 6.0};
        double[] vector2 = {3.0, 6.0, 7.0};
        double[] vector3 = {3.0};
        double[] vector4 = {3.0, 6.0, 7.0, 9.0};

        Console.WriteLine($"Lenght vector1 is {VectorMath.Magnitude(vector1)}");
        Console.WriteLine($"Lenght vector2 is {VectorMath.Magnitude(vector2)}");
        Console.WriteLine($"Lenght vector3 is {VectorMath.Magnitude(vector3)}");
        Console.WriteLine($"Lenght vector4 is {VectorMath.Magnitude(vector4)}");
    }
}