using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 9; i++)
            {
                for(int j = 0; j <= 9; j++)
                {
                    if (i == j || j < i)
                        continue;
                    if (i == 8 && j == 9)
                        Console.WriteLine($"{i}{j}");
                    else
                        Console.Write($"{i}{j}, ");                                            
                }
            };
        }
    }
}
