public class Solution {
    
    public int MaxProfit(int[] prices) {
        
        int maxProfit = 0;
        int start = 0;
        int end = 1;
        while(end < prices.Length)
        {
            if(prices[start] > prices[end])
            {
                start = end;
            }
            else
            {
                maxProfit = Math.Max(maxProfit, prices[end] - prices[start]);
            }
            end++;
        }
        return maxProfit;
    }

    static void Main()
    {
        int[] prices = [10,1,5,6,7,1];
        Solution s = new();
        Console.WriteLine(s.MaxProfit(prices));
    }
}