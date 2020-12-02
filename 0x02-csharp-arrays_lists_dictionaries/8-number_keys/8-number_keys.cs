using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keysCount = 0;
        
        foreach (KeyValuePair<string, string> kvp in myDict)
        {
            keysCount++;
        }
        return keysCount;
    }
}
