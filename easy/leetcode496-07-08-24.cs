// https://leetcode.com/problems/next-greater-element-i/

/*

496. Next Greater Element I


The next greater element of some element x in an array is the first greater element that is to the right of x in the same array.

You are given two distinct 0-indexed integer arrays nums1 and nums2, where nums1 is a subset of nums2.

For each 0 <= i < nums1.length, find the index j such that nums1[i] == nums2[j] and determine the next greater element of nums2[j] in nums2. If there is no next greater element, then the answer for this query is -1.

Return an array ans of length nums1.length such that ans[i] is the next greater element as described above.

 

Example 1:

Input: nums1 = [4,1,2], nums2 = [1,3,4,2]
Output: [-1,3,-1]
Explanation: The next greater element for each value of nums1 is as follows:
- 4 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.
- 1 is underlined in nums2 = [1,3,4,2]. The next greater element is 3.
- 2 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.
Example 2:

Input: nums1 = [2,4], nums2 = [1,2,3,4]
Output: [3,-1]
Explanation: The next greater element for each value of nums1 is as follows:
- 2 is underlined in nums2 = [1,2,3,4]. The next greater element is 3.
- 4 is underlined in nums2 = [1,2,3,4]. There is no next greater element, so the answer is -1.
 

Constraints:

1 <= nums1.length <= nums2.length <= 1000
0 <= nums1[i], nums2[i] <= 104
All integers in nums1 and nums2 are unique.
All the integers of nums1 also appear in nums2.

*/

using System;
using System.Collections.Generic;


public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        // Dictionary to store the next greater element for each number in nums2
        Dictionary<int, int> nextGreaterMap = new Dictionary<int, int>();
        Stack<int> stack = new Stack<int>();

        // Iterate over nums2 to populate the next greater element map
        foreach (int num in nums2) {
            // If the current number is greater than the stack's top element, 
            // it means it's the next greater element for that top element
            while (stack.Count > 0 && stack.Peek() < num) {
                nextGreaterMap[stack.Pop()] = num;
            }
            // Push the current number onto the stack
            stack.Push(num);
        }

        // For remaining elements in the stack, there is no next greater element
        while (stack.Count > 0) {
            nextGreaterMap[stack.Pop()] = -1;
        }

        // Build the result for nums1 using the next greater element map
        int[] result = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++) {
            result[i] = nextGreaterMap[nums1[i]];
        }

        return result;
    }
}





void TestSolution() {
 Solution solution = new Solution();

        // Test case 1
        int[] nums1_1 = {4, 1, 2};
        int[] nums2_1 = {1, 3, 4, 2};
        int[] result1 = solution.NextGreaterElement(nums1_1, nums2_1);
        Console.WriteLine($"Result 1: {string.Join(", ", result1)}"); // Expected: [-1, 3, -1]

        // Test case 2
        int[] nums1_2 = {2, 4};
        int[] nums2_2 = {1, 2, 3, 4};
        int[] result2 = solution.NextGreaterElement(nums1_2, nums2_2);
        Console.WriteLine($"Result 2: {string.Join(", ", result2)}"); // Expected: [3, -1]
}

// Call the test function
TestSolution();

