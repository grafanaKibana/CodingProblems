namespace LeetCodeCs.SlidingWindow;

public static partial class Problem
{
    public static int MaxProfit(int[] prices) {
        var profit = 0;

        var buy = prices[0];

        for (var i = 1; i < prices.Length; i++){
            var sell = prices[i];
            if(sell > buy){
                var diff = sell - buy;
                profit = profit > diff ? profit : diff;
            }
            else{
                buy = sell;
            }
        }

        return profit;
    }
}
