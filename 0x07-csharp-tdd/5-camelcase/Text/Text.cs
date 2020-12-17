using System;

namespace Text
{
    /// <summary>Represents Text Operations.</summary>
    public class Str
    {
        /// <summary>Method that determines how many words are in a string.</summary>
        /// <param name="s">A string.</param>
        /// <returns>number of words in s</returns>
        public static int CamelCase(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (count == 0)
                    count++;
                if ('A' <= s[i] && s[i] <= 'Z')
                    count++;
            }
            return count;
        }
    }
}
