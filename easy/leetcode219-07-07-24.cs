
// https://leetcode.com/problems/contains-duplicate-ii/

/*
219. Contains Duplicate II
Easy
Topics
Companies
Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

 

Example 1:

Input: nums = [1,2,3,1], k = 3
Output: true
Example 2:

Input: nums = [1,0,1,1], k = 1
Output: true
Example 3:

Input: nums = [1,2,3,1,2,3], k = 2
Output: false
 

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109
0 <= k <= 105

*/

using System;
using System.Collections.Generic;

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        // Dictionary to store the most recent index of each element
        Dictionary<int, int> indexMap = new Dictionary<int, int>();

        // Iterate through the array
        for (int i = 0; i < nums.Length; i++) {
            if (indexMap.ContainsKey(nums[i])) {
                // Check if the difference between indices is less than or equal to k
                if (i - indexMap[nums[i]] <= k) {
                    return true;
                }
            }
            // Update the dictionary with the current index
            indexMap[nums[i]] = i;
        }

        // No such pair found
        return false;
    }
}
