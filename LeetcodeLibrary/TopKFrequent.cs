using System.Collections.Generic;
using System.Linq;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        //https://leetcode.com/problems/top-k-frequent-elements/
        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach(var i in nums)
            {
                if (map.ContainsKey(i))
                {
                    ++map[i];
                }
                else
                {
                    map.Add(i, 1);
                }
            }

            return map.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
        }
    }
}
