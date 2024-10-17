namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        //https://leetcode.com/problems/sort-colors/
        public static void SortColors(int[] nums)
        {
            short[] items = new short[3];
            for(short i = 0;i < nums.Length; ++i)
            {
                ++items[nums[i]];
            }

            byte j = 0;
            for(short i = 0; i < nums.Length;)
            {
                while (items[j]-- > 0)
                {
                    nums[i++] = j;
                }

                ++j;
            }
        }
    }
}
