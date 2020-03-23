using System;

namespace _1_Two_Sum
{
    // leetcode start -----
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] find = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        find[0] = i;
                        find[1] = j;
                        return find;
                    }
                }
            }
            return find;
        }
    }
    // leetcode end -----
}
