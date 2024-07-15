using System;

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

void TestSolution() {
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

// Execute the test cases
TestSolution();
