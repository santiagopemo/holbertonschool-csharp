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
        double[,] matrix1 = {{2, 2}, {-9, 4}};

        Console.Write($"{MatrixToString(matrix1)}\tDeterminant\n");
        Console.WriteLine($"\t=\n{MatrixMath.Determinant(matrix1)}");
        Console.WriteLine("------------\n");

        double[,] matrix2 = {{-4, 9, 0}, {1, -2, 1}, {3, -4, 2}};

        Console.Write($"{MatrixToString(matrix2)}\tDeterminant\n");
        Console.WriteLine($"\t=\n{MatrixMath.Determinant(matrix2)}");
        Console.WriteLine("------------\n");


        double[,] matrix3 = {{1, 2, 3}, {4, 5, 6}};

        Console.Write($"{MatrixToString(matrix3)}\tDeterminant\n");
        Console.WriteLine($"\t=\n{MatrixMath.Determinant(matrix3)}");
        Console.WriteLine("------------\n");
    }
}