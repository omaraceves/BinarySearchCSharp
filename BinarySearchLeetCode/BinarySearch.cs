using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchLeetCode
{
    /// <summary>
    /// Solution
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Search
        /// </summary>
        /// <param name="nums">Nums</param>
        /// <param name="target">Target</param>
        /// <returns></returns>
        public int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int middle = (start + end) / 2;

            while (nums[middle] != target && end >= start)
            {
                if (nums[middle] > target) //target could be on the left side
                {
                    end = middle - 1;
                    middle = (start + end) / 2;
                }
                else //target could be on the right side
                {
                    start = middle + 1;
                    middle = (start + end) / 2;
                }
            }

            if (nums[middle] == target) // target was found
            {
                return middle;
            }

            return -1; //target was not found
        }
    }
}
