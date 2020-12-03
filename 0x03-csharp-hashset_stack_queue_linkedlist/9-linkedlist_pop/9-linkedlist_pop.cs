using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        LinkedListNode<int> firstNode = myLList.First;

        if (firstNode == null)
            return 0;
        int nodeData = firstNode.Value;
        myLList.RemoveFirst();
        return nodeData;
    }
}
