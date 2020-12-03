using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> tmp = myLList.First;

        if (tmp == null)
        {
            myLList.AddFirst(n);
            return myLList.First;
        }
        for (; tmp.Next != null; tmp = tmp.Next)
        {            
            if (n < tmp.Next.Value && n >= tmp.Value)
            {
                myLList.AddAfter(tmp, n);
                return tmp;
            }
        }
        if (n < tmp.Value)
        {
            myLList.AddBefore(tmp, n);
            return tmp.Previous;
        }            
        else
        {
            myLList.AddLast(n);
            return myLList.Last;
        }                    
    }
}
