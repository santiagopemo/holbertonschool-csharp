using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[5, 5];

            array2D[2, 2] = 1;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j]);
                    if (j < array2D.GetLength(1) - 1)
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}
