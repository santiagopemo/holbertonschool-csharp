using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] arr = new int[size];
        if (size == 0)
        {
            Console.WriteLine();
            return arr;
        }        
        for (int i = 0; i < size; i++)
        {
            Console.Write(i);
            if (i < size - 1)
                Console.Write(" ");
            else
                Console.Write("\n");
            arr[i] = i;
        }
        return arr;
    }
}
