// leetcode two sum

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> check = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (check.ContainsKey(complement)) {
                return new int[] { check[complement], i };
            }

            if (!check.ContainsKey(nums[i])) {
                check.Add(nums[i], i);
            }
        }

        // If no solution is found, throw an exception or return an appropriate value
        throw new ArgumentException("No two sum solution");
    }
}
