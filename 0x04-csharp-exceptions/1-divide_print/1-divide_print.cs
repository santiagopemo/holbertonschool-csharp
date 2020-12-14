using System;

class Int
{
    public static void divide(int a, int b)
    {
        int result = 0;

        try
        {
            result = a / b;
        }
        catch
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {result}");
        }
    }
}
