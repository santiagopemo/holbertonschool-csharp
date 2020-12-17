using System;

namespace Text
{
    /// <summary>Represents Text Operations.</summary>
    public class Str
    {
        /// <summary>Method that identifies the index of the first non-repeating character of a string.</summary>
        /// <param name="s">A string.</param>
        /// <returns>Index of first non-repeating character or -1</returns>
        public static int UniqueChar(string s)
        {
            bool isUniq;

            for (int i = 0; i < s.Length; i++)
            {
                isUniq = true;
                for (int j = 0; j < s.Length; j++)
                {
                    if (j != i && s[i] == s[j])
                    {
                        isUniq = false;
                        break;
                    }
                }
                if (isUniq)
                    return i;
            }
            return -1;
        }
    }
}
