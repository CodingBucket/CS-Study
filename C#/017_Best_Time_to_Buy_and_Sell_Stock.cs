public class Solution {
    public int MaxProfit(int[] prices) {
        var profit = 0;
        var left = 0;
        var right = 1;
        for (var i=1; i<prices.Length; i++)
        {
            if (prices[left] < prices[right])
            {
                var max = prices[right] - prices[left];
                profit = Math.Max(max, profit);
            }
            else
                left = right;
            right++;
        }
        return profit;
    }
}
