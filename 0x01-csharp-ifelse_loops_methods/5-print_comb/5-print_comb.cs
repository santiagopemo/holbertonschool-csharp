using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 99; i++)
            {
                string output = i.ToString("D2");
                if (i < 99)
                    output += ", ";
                else
                    output += "\n";
                Console.Write(output);
            }
        }
    }
}
