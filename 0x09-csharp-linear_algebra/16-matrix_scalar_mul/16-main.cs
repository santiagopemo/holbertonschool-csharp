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
        double[,] matrix1 = {{1, 3}, {1, 5}};
        int scalar = 2;

        Console.WriteLine($"{MatrixToString(matrix1)}\t*\n{scalar}");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.MultiplyScalar(matrix1, scalar))}");
        Console.WriteLine("------------\n");

        double[,] matrix3 = {{-13, 10, 8}, {2, 0, 14}, {-4, -5, 2}};
        scalar = 4;

        Console.WriteLine($"{MatrixToString(matrix3)}\t*\n{scalar}");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.MultiplyScalar(matrix3, scalar))}");
        Console.WriteLine("------------\n");

        double[,] matrix5 = {{1}};
        scalar = 2;

        Console.WriteLine($"{MatrixToString(matrix5)}\t*\n{scalar}");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.MultiplyScalar(matrix5, scalar))}");
        Console.WriteLine("------------\n");

        double[,] matrix7 = {{1, 3, 1 , 2}, {1, 3, 1 , 2}, {1, 3, 1 , 2}, {1, 3, 1 , 2}};
        scalar = 2;

        Console.WriteLine($"{MatrixToString(matrix7)}\t*\n{scalar}");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.MultiplyScalar(matrix7, scalar))}");
        Console.WriteLine("------------\n");
    }
}