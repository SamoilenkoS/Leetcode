﻿namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        //https://leetcode.com/problems/product-of-array-except-self/description/
        public static int[] ProductExceptSelf(int[] nums)
        {
            int length = nums.Length;
            int[] prefix = new int[length];
            int[] suffix = new int[length];
            prefix[0] = 1;
            suffix[length - 1] = 1;

            for (int i = 1; i < length; i++)
            {
                prefix[i] = prefix[i - 1] * nums[i - 1];
            }
            for (int i = length - 2; i >= 0; i--)
            {
                suffix[i] = suffix[i + 1] * nums[i + 1];
            }
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = prefix[i] * suffix[i];
            }

            return result;
        }
    }
}