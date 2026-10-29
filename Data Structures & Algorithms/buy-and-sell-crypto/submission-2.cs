public class Solution {
    public int MaxProfit(int[] prices) {
        var minPrice = prices[0];
        var max = 0;

        for(int i = 1; i < prices.Length; i++)
        {
            var current = prices[i];

            if(minPrice < current)
            {
                max = Math.Max(max, current - minPrice);
            }

            minPrice = Math.Min(minPrice, current);
        }

        return max;
    }
}
