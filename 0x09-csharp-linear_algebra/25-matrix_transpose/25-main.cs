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
            for (j = 0; j < matrix.GetLength(1); j++)
            {
                if (j < matrix.GetLength(1) - 1)
                    output += $"{matrix[i, j]}, ";
                else
                    output += $"{matrix[i, j]}";
            }
            output += ")\n";
        }
        return output;
    }
    static void Main(string[] args)
    {
        double[,] matrix1 = {{1, 2}, {3, 4}};

        Console.Write($"{MatrixToString(matrix1)}\tTranspose\n");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Transpose(matrix1))}");
        Console.WriteLine("------------\n");

        double[,] matrix2 = {{1, 2, 3}, {4, 5, 6}};

        Console.Write($"{MatrixToString(matrix2)}\tTranspose\n");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Transpose(matrix2))}");
        Console.WriteLine("------------\n");

        double[,] matrix3 = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};

        Console.Write($"{MatrixToString(matrix3)}\tTranspose\n");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Transpose(matrix3))}");
        Console.WriteLine("------------\n");

        double[,] matrix4 = {{}};

        Console.Write($"{MatrixToString(matrix4)}\tTranspose\n");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Transpose(matrix4))}");
        Console.WriteLine("------------\n");
    }
}