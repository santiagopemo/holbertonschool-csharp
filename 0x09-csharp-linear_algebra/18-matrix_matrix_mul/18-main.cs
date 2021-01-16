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
        double[,] matrix1 = {{2, 3}, {-1, 0}};
        double[,] matrix2 = {{1, 7}, {-8, -2}};

        Console.Write($"{MatrixToString(matrix1)}\t*\n{MatrixToString(matrix2)}");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Multiply(matrix1, matrix2))}");
        Console.WriteLine("------------\n");

        double[,] matrix3 = {{4, 2}, {3, -2}, {0, -1}};
        double[,] matrix4 = {{2, 1, 3}, {-1, 5, 8}};

        Console.Write($"{MatrixToString(matrix3)}\t*\n{MatrixToString(matrix4)}");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Multiply(matrix3, matrix4))}");
        Console.WriteLine("------------\n");


        double[,] matrix5 = {{1, 0, 2}, {2, -1, 3}, {4, -2, -3}};
        double[,] matrix6 = {{-4}, {5}, {6}};

        Console.Write($"{MatrixToString(matrix5)}\t*\n{MatrixToString(matrix6)}");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Multiply(matrix5, matrix6))}");
        Console.WriteLine("------------\n");

        double[,] matrix7 = {{1, 3, 1 , 2}, {1, 3, 1 , 2}, {1, 3, 1 , 2}, {1, 3, 1 , 2}};
        double[,] matrix8 = {{1, 3, 1 , 2}, {1, 3, 1 , 2}};

        Console.Write($"{MatrixToString(matrix7)}\t*\n{MatrixToString(matrix8)}");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Multiply(matrix7, matrix8))}");
        Console.WriteLine("------------\n");
    }
}