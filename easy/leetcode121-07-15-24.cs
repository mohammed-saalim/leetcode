// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/

/* 121. Best Time to Buy and Sell Stock
Solved
Easy
Topics
Companies
You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

 

Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.
 

Constraints:

1 <= prices.length <= 105
0 <= prices[i] <= 104

*/

public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0) return 0;
        
        int minPrice = prices[0];
        int maxProfit = 0;
        
        for (int i = 1; i < prices.Length; i++) {
            // Update the minimum price if the current price is lower
            if (prices[i] < minPrice) {
                minPrice = prices[i];
            }
            
            // Calculate the potential profit and update the max profit if this profit is higher
            int potentialProfit = prices[i] - minPrice;
            if (potentialProfit > maxProfit) {
                maxProfit = potentialProfit;
            }
        }
        
        return maxProfit;
    }
}

class Program {
    static void Main(string[] args) {
        Solution solution = new Solution();

        // Test case 1
        int[] prices1 = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine($"Test 1: {solution.MaxProfit(prices1)}");  // Expected: 5

        // Test case 2
        int[] prices2 = { 7, 6, 4, 3, 1 };
        Console.WriteLine($"Test 2: {solution.MaxProfit(prices2)}");  // Expected: 0

        // Additional test cases
        int[] prices3 = { 2, 4, 1 };
        Console.WriteLine($"Test 3: {solution.MaxProfit(prices3)}");  // Expected: 2

        int[] prices4 = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Test 4: {solution.MaxProfit(prices4)}");  // Expected: 4

        int[] prices5 = { 7, 2, 5, 1, 3, 6 };
        Console.WriteLine($"Test 5: {solution.MaxProfit(prices5)}");  // Expected: 5
    }
}
