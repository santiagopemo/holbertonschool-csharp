using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>Represents Mathematical Operations.</summary>
    public class Operations
    {
        /// <summary>Method that returns the max integer in a list of integers.</summary>
        /// <param name="nums">A list of integers.</param>
        /// <returns>Max integer in list</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count <= 0)
                return 0;
            int max = nums[0];
            foreach (int num in nums)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }
    }
}
