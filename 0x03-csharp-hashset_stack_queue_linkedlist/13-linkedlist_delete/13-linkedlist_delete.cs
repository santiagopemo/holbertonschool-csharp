using System;
using System.Collections.Generic;
class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> tmp = myLList.First;
        for (int i = 0; tmp != null; tmp = tmp.Next, i++)
        {
            if (i == index)
            {
                myLList.Remove(tmp);
                break;
            }
        }
    }
}
