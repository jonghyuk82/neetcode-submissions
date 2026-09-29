public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = 0;
        var day = 0;
        var lowestPrice = prices[day];

        for(int i = 1; i < prices.Length; i++)
        {
            var buyPrice = prices[day];
            var currentPrice = prices[i];

            var profit = currentPrice - buyPrice;
            maxProfit = Math.Max(maxProfit, profit);

            lowestPrice = Math.Min(lowestPrice, currentPrice);

            if(buyPrice > currentPrice)
            {
                day = i;
            }
        }

        return maxProfit;
    }
}
