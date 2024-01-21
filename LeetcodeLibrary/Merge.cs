using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        //https://leetcode.com/problems/merge-sorted-array/
        public static void Merge(
            int[] nums1, int m,
            int[] nums2, int n)
        {
            int lI = 0;
            int rI = 0;
            var tempItems = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                int? left = m > 0 ? tempItems.Any() ? tempItems.First() : nums1[lI] : null;
                int? right = n > 0 ? nums2[rI] : null;
                var response = SelectAndManipulate(left, right);
                if (response.IsLeft)
                {
                    if (tempItems.Any())
                    {
                        tempItems.RemoveAt(0);
                    }
                    if (i > lI)
                    {
                        tempItems.Add(nums1[i]);
                    }

                    lI++;
                    m--;
                }
                else
                {
                    rI++;
                    n--;
                    if (tempItems.Any())
                    {
                        tempItems.Add(nums1[i]);
                    }
                    else if (left.HasValue)
                    {
                        tempItems.Add(left.Value);
                    }
                }

                nums1[i] = response.MinValue;
            }
        }

        private static (bool IsLeft, int MinValue) SelectAndManipulate(int? left, int? right)
        {
            if (left == null)
            {
                return (false, right!.Value);
            }
            if (right == null)
            {
                return (true, left!.Value);
            }

            if (left.Value <= right.Value)
            {
                return (true, left.Value);
            }
            else
            {
                return (false, right.Value);
            }
        }
    }
}
