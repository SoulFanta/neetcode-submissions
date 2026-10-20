public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int j = 0;
        for (int i = 0; i < prices.Length; i++) {
            if (prices[i] < prices[j]) {
                j = i;
            }

            profit = Math.Max(profit, prices[i] - prices[j]);
        }
        return profit;
    }
}