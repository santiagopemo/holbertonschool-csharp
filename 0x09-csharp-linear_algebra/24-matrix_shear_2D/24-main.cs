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
        double factor = 2;
        char direction = 'x';

        Console.Write($"{MatrixToString(matrix1)}\tShear\n{factor} in {direction}\n");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Shear2D(matrix1, direction, factor))}");
        Console.WriteLine("------------\n");

        factor = 2;
        direction = 'y';

        Console.Write($"{MatrixToString(matrix1)}\tShear\n{factor} in {direction}\n");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Shear2D(matrix1, direction, factor))}");
        Console.WriteLine("------------\n");

        double[,] matrix2 = {{1, 2, 3}, {3, 4, 5}};

        Console.Write($"{MatrixToString(matrix2)}\tShear\n{factor} in {direction}\n");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Shear2D(matrix2, direction, factor))}");
        Console.WriteLine("------------\n");

        direction = 'z';

        Console.Write($"{MatrixToString(matrix1)}\tShear\n{factor} in {direction}\n");
        Console.WriteLine($"\t=\n{MatrixToString(MatrixMath.Shear2D(matrix1, direction, factor))}");
        Console.WriteLine("------------\n");
    }
}