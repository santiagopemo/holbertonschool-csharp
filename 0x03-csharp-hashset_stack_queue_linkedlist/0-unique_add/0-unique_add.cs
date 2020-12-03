using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int current, prev, sum;
        current = prev = sum = 0;

        myList.Sort();
        foreach (int number in myList)
        {
            prev = current;
            current = number;
            if (prev == current)
                continue;
            sum += number;
        }
        return sum;
    }
}
