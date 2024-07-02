/*

Question: https://leetcode.com/problems/intersection-of-two-arrays/description/

350. Intersection of Two Arrays II

Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.

 

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2,2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [4,9]
Explanation: [9,4] is also accepted.
 

Constraints:

1 <= nums1.length, nums2.length <= 1000
0 <= nums1[i], nums2[i] <= 1000

*/


using System;
using System.Collections.Generic;

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> counter = new Dictionary<int, int>();

        // Count occurrences of each element in nums1
        foreach (int i in nums1) {
            if (!counter.ContainsKey(i)) {
                counter.Add(i, 1);
            } else {
                counter[i]++;
            }
        }

        // List to store the intersection result
        List<int> finalop = new List<int>();
        
        // Find intersection with nums2
        foreach (int i in nums2) {
            int checker = 0;
            if (counter.TryGetValue(i, out checker) && checker > 0) {
                finalop.Add(i);
                counter[i]--; // Decrement the count
            }
        }

        return finalop.ToArray(); // Convert list to array
    }
}
