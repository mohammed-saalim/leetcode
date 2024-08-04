public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequents = new Dictionary<int, int>();
        foreach(int num in nums){
            if(frequents.ContainsKey(num)) frequents[num]++;
            else frequents[num] = 1;
        }

        var sortedFrequents = frequents.OrderByDescending(pair => pair.Value);
        return sortedFrequents.Take(k).Select(pair => pair.Key).ToArray();

    }
}


void TestSolution() {
    Solution solution = new Solution();

    // Example input
    int[] nums = { 1, 1, 1, 2, 2, 3 };
    int k = 2;
    
    // Get the result
    int[] result = solution.TopKFrequent(nums, k);
    
    // Print the result
    Console.WriteLine($"[{string.Join(", ", result)}]");
}

// Execute the test case
TestSolution();