using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>Represents Text Operations.</summary>
    public class Str
    {
        /// <summary>Method that identifies if a string is a palindrome or not.</summary>
        /// <param name="s">A string.</param>
        /// <returns>True if string is a palindrome, False if it’s not</returns>
        public static bool IsPalindrome(string s)
        {
            string modS = s.ToLower();
            modS = Regex.Replace(modS, "[:;,. \t\n\r]", string.Empty);

            for (int i = 0, j = modS.Length - 1; i <= j; i++, j--)
            {
                if (modS[i] != modS[j])
                    return false;
            }
            return true;
        }
    }
}
