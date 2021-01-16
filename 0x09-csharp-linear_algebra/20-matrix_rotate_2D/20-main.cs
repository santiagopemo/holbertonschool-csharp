using System;

class Program
{
    static string MatrixToString(double[,] matrix)
    {
        int i, j;
        string output = string.Empty;
        for (i = 0; i < matrix.GetLength(0); i++)
        {
            output += "(";
            for (j = 0; j < matrix.GetLength(1) - 1; j++)
                output += $"{matrix[i, j]}, ";
            output += $"{matrix[i, j]})\n";
        }
        return output;
    }
    static void Main(string[] args)
    {
        double[,] matrix1 = {{1, 2}, {3, 4}};
        double angle = -1.57;

        Console.Write($"{MatrixToString(matrix1)}\tRotate\n{angle} radians\n");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Rotate2D(matrix1, angle))}");
        Console.WriteLine("------------\n");

        double[,] matrix4 = {{2, 1, 3}, {-1, 5, 8}};

        Console.Write($"{MatrixToString(matrix4)}\tRotate\n{angle} radians\n");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Rotate2D(matrix4, angle))}");
        Console.WriteLine("------------\n");
    }
}