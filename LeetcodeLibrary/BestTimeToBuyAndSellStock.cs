namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        //https://leetcode.com/problems/best-time-to-buy-and-sell-stock
        public static int BestTimeToBuyAndSellStock(int[] prices)
        {
            int result = 0;
            for (int i = 0, j = i + 1; j < prices.Length && i < prices.Length;)
            {
                var current = prices[j] - prices[i];
                if (current > result)
                {
                    result = current;
                }
                if (prices[i] > prices[j])
                {
                    ++i;
                }
                else
                {
                    ++j;
                }
            }

            return result;
        }
    }
}
