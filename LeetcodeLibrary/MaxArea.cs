using System;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        // https://leetcode.com/problems/container-with-most-water/
        public static int MaxArea(int[] height)
        {
            int result = 0;
            for (int i = 0, j = height.Length - 1; i < height.Length && j > i;)
            {
                var min = MinI(height, i, j);
                var currentResult = (j - i) * height[min];
                if (currentResult > result)
                {
                    result = currentResult;
                }
                if(min == i)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return result;
        }

        private static int MinI(int[] height, int i, int j)
        {
            return height[i] < height[j] ? i : j;
        }
    }
}
