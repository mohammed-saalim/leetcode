using System;
using System.Collections.Generic;
using System.Linq;

// public class Solution {
//     public int[] TopKFrequent(int[] nums, int k) {
//         // Edge case: if nums is empty or null, return an empty array
//         if (nums == null || nums.Length == 0) {
//             return new int[0];
//         }

//         // Step 1: Count the frequency of each element
//         Dictionary<int, int> map = new Dictionary<int, int>();
//         foreach (int num in nums) {
//             if (!map.ContainsKey(num)) {
//                 map[num] = 0;
//             }
//             map[num]++;
//         }

//         // Step 2: Use LINQ to group by frequency and select the top k elements
//         var result = map
//             .GroupBy(pair => pair.Value);


//             // .OrderByDescending(group => group.Key)
//             // .SelectMany(group => group.Select(pair => pair.Key))
//             // .Take(k)
//             // .ToArray();

//         return result;
//     }
// }

// Test case
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