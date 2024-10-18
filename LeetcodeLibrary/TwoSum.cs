using System.Collections.Generic;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        //https://neetcode.io/problems/two-integer-sum
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> items = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; ++i)
            {
                if (!items.ContainsKey(nums[i]))
                {
                    items.Add(nums[i], i);
                    var remainPart = target - nums[i];
                    if (items.ContainsKey(remainPart) && items[remainPart] != i)
                    {
                        return new int[] { items[remainPart], i };
                    }
                }
                else
                {
                    if (target == nums[i] * 2)
                    {
                        return new int[] { items[nums[i]], i };
                    }
                }
            }

            return new int[] { };
        }
    }
}
