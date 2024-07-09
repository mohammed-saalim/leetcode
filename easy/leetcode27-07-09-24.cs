public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0;
        for (int j = 0; j < nums.Length; j++) {
            if (nums[j] != val) {
                nums[i] = nums[j];
                i++;
            }
        }
        return i;
    }
}

class Program {
    static void Main(string[] args) {
        Solution solution = new Solution();

        // Test case 1
        int[] nums1 = { 3, 2, 2, 3 };
        int val1 = 3;
        int result1 = solution.RemoveElement(nums1, val1);
        Console.WriteLine($"Result 1: {result1}, Array: {string.Join(", ", nums1.Take(result1))}"); // Expected: 2, Array: [2, 2]

        // Test case 2
        int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val2 = 2;
        int result2 = solution.RemoveElement(nums2, val2);
        Console.WriteLine($"Result 2: {result2}, Array: {string.Join(", ", nums2.Take(result2))}"); // Expected: 5, Array: [0, 1, 3, 0, 4]

        // Additional test cases can be added here
    }
}
