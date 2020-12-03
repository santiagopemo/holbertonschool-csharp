using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
            return "None";
        int i = 0;
        KeyValuePair<string, int> bestScore = new KeyValuePair<string, int>();

        foreach (KeyValuePair<string, int> kvp in myList)
        {
            if (i == 0 || kvp.Value > bestScore.Value)
                bestScore = kvp;
            i++;
        }
        return bestScore.Key;
    }
}
