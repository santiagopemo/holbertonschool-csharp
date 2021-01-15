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
        double[,] matrix2 = {{2, 1}, {1, 2}};

        Console.Write($"{MatrixToString(matrix1)}\t+\n{MatrixToString(matrix2)}");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Add(matrix1, matrix2))}");
        Console.WriteLine("------------\n");

        double[,] matrix3 = {{14, -3, 0}, {-11, -5, 3}, {2, -9, 13}};
        double[,] matrix4 = {{6, 16, 21}, {5, 2, 0}, {1, 3, 7}};

        Console.Write($"{MatrixToString(matrix3)}\t+\n{MatrixToString(matrix4)}");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Add(matrix3, matrix4))}");
        Console.WriteLine("------------\n");

        Console.Write($"{MatrixToString(matrix2)}\t+\n{MatrixToString(matrix4)}");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Add(matrix2, matrix4))}");
        Console.WriteLine("------------\n");

        double[,] matrix5 = {{1}};
        double[,] matrix6 = {{2}};

        Console.Write($"{MatrixToString(matrix5)}\t+\n{MatrixToString(matrix6)}");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Add(matrix5, matrix6))}");
        Console.WriteLine("------------\n");

        double[,] matrix7 = {{1, 3, 1 , 2}, {1, 3, 1 , 2}, {1, 3, 1 , 2}, {1, 3, 1 , 2}};
        double[,] matrix8 = {{1, 3, 1 , 2}, {1, 3, 1 , 2}, {1, 3, 1 , 2}, {1, 3, 1 , 2}};

        Console.Write($"{MatrixToString(matrix7)}\t+\n{MatrixToString(matrix8)}");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Add(matrix7, matrix8))}");
        Console.WriteLine("------------\n");
    }
}