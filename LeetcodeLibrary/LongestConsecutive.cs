using System.Collections.Generic;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        public static int LongestConsecutive(int[] nums)
        {
            var set = new SortedSet<int>(nums);

            int longest = 0 ;
            int current = 0;
            int previousNum = int.MinValue;
            foreach(var x in set)
            {
                if((x - previousNum) == 1)
                {
                    current++;
                }
                else
                {
                    if (current > longest)
                    {
                        longest = current;
                    }

                    current = 1;
                }

                previousNum = x;
            }

            if (current > longest)
            {
                longest = current;
            }

            return longest;
        }
    }
}
