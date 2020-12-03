using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = -1;
        int i = 0;

        foreach (int n in myLList)
        {
            if (n == value)
            {
                index = i;
                break;
            }
            i++;
        }
        return index;
    }
}
