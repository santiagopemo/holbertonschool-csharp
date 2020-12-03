using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        SortedList<string, string> newDict = new SortedList<string, string>(myDict);
        
        foreach (KeyValuePair<string, string> kvp in newDict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
