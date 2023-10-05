using System.Globalization;
using System.Net;
using System.Runtime;

namespace LC_0035_SearchInsertPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        
            Code
            Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
            
            You must write an algorithm with O(log n) runtime complexity.
            
            Example 1:
            Input: nums = [1,3,5,6], target = 5
            Output: 2
            
            Example 2:
            Input: nums = [1,3,5,6], target = 2
            Output: 1
            
            Example 3:
            Input: nums = [1,3,5,6], target = 7
            Output: 4
             
            Constraints:
            1 <= nums.length <= 104
            -104 <= nums[i] <= 104
            nums contains distinct values sorted in ascending order.
            -104 <= target <= 104
            */

            //int[] nums = new int[4] { 1, 3, 5, 6 };
            //var target = 5;

            //int[] nums = new int[4] { 1, 3, 5, 6 };
            //var target = 2;

            //int[] nums = new int[4] { 1, 3, 5, 6 };
            //var target = 7;

            int[] nums = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var target = 1;

            Console.WriteLine("Index is {0}", Solution.SearchInsert(nums, target));
        }

        public static class Solution
        {
            public static int SearchInsert(int[] nums, int target)
            {
                // Do a while loop as unknown # of iterations
                // exit on either finding target or number below or above target
                // Search by going to mid, and then halfway between mid and higher or lower
                // Keep track of index
                // This method is just divide by 2, and interate by 1 which is O(n/2) vs O(logn)

                var lowIndex = 0;
                var highIndex = nums.Length - 1;
                int midPoint;

                while (lowIndex <= highIndex)
                {
                    midPoint = lowIndex + (highIndex - lowIndex) /2;

                    // If on target
                    if (nums[midPoint] == target)
                        return midPoint;

                    // If target is less
                    if (target < nums[midPoint])
                    {
                        highIndex = highIndex - 1;
                    }
                    else if (target > nums[midPoint])
                    {
                        lowIndex = lowIndex + 1;
                    }
                }

                return lowIndex;
            }
        }
    }
}