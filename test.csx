




//https://leetcode.com/problems/count-pairs-that-form-a-complete-day-i/


/*

3184. Count Pairs That Form a Complete Day I


Hint
Given an integer array hours representing times in hours, return an integer denoting the number of pairs i, j where i < j and hours[i] + hours[j] forms a complete day.

A complete day is defined as a time duration that is an exact multiple of 24 hours.

For example, 1 day is 24 hours, 2 days is 48 hours, 3 days is 72 hours, and so on.

 

Example 1:

Input: hours = [12,12,30,24,24]

Output: 2

Explanation:

The pairs of indices that form a complete day are (0, 1) and (3, 4).

Example 2:

Input: hours = [72,48,24,3]

Output: 3

Explanation:

The pairs of indices that form a complete day are (0, 1), (0, 2), and (1, 2).

 

Constraints:

1 <= hours.length <= 100
1 <= hours[i] <= 109





*/




using System;

public class Solution {
    public int CountCompleteDayPairs(int[] hours) {
        // Step 1: Initialize a frequency array to count remainders
        int[] remainderCounts = new int[24];
        
        // Step 2: Populate the frequency array with remainders
        foreach (int hour in hours) {
            int remainder = hour % 24;
            remainderCounts[remainder]++;
        }
        
        // Step 3: Count the pairs
        int pairCount = 0;
        
        // Handle the remainder 0 separately
        if (remainderCounts[0] > 1) {
            pairCount += remainderCounts[0] * (remainderCounts[0] - 1) / 2;
        }
        
        // Handle remainders from 1 to 11
        for (int r = 1; r <= 11; r++) {
            pairCount += remainderCounts[r] * remainderCounts[24 - r];
        }
        
        // Handle the remainder 12 separately
        if (remainderCounts[12] > 1) {
            pairCount += remainderCounts[12] * (remainderCounts[12] - 1) / 2;
        }
        
        return pairCount;
    }
}



void TestSolution() {
    Solution solution = new Solution();

    int[] hours1 = {12, 12, 30, 24, 24};
    Console.WriteLine(solution.CountCompleteDayPairs(hours1)); // Expected output: 2

    int[] hours2 = {72, 48, 24, 3};
    Console.WriteLine(solution.CountCompleteDayPairs(hours2)); // Expected output: 3
}

// Call the test function
TestSolution();