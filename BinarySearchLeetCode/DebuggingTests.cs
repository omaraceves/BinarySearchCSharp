using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchLeetCode
{
    /// <summary>
    /// Debugging tests
    /// </summary>
    public static class DebuggingTests
    {
        /// <summary>
        /// Test1
        /// </summary>
        public static int Test1()
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            Console.WriteLine(string.Join(",", nums));
            int target = 0;

            return Search(nums, target);
        }

        /// <summary>
        /// Test2
        /// </summary>
        public static int Test2()
        {
            int[] nums = {2, 5};
            Console.WriteLine(string.Join(",", nums));
            int target = 0;

            return Search(nums, target);
        }

        /// <summary>
        /// Search 
        /// </summary>
        /// <param name="nums">Nums</param>
        /// <param name="target">Target</param>
        /// <returns></returns>
        private static int Search(int[] nums, int target)
        {
            var solution = new Solution();
            var index = solution.Search(nums, target);

            if (index != -1)
            {
                Console.WriteLine("index of {0} is {1}", target, index);
            }
            else
            {
                Console.WriteLine("Target not found");
            }

            return index;
        }
    }
}
