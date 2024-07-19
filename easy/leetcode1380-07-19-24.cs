/* 1380. Lucky Numbers in a Matrix
Solved
Easy
Topics
Companies
Hint
Given an m x n matrix of distinct numbers, return all lucky numbers in the matrix in any order.

A lucky number is an element of the matrix such that it is the minimum element in its row and maximum in its column.

 

Example 1:

Input: matrix = [[3,7,8],[9,11,13],[15,16,17]]
Output: [15]
Explanation: 15 is the only lucky number since it is the minimum in its row and the maximum in its column.
Example 2:

Input: matrix = [[1,10,4,2],[9,3,8,7],[15,16,17,12]]
Output: [12]
Explanation: 12 is the only lucky number since it is the minimum in its row and the maximum in its column.
Example 3:

Input: matrix = [[7,8],[1,2]]
Output: [7]
Explanation: 7 is the only lucky number since it is the minimum in its row and the maximum in its column.
 

Constraints:

m == mat.length
n == mat[i].length
1 <= n, m <= 50
1 <= matrix[i][j] <= 105.
All elements in the matrix are distinct.*/


using System;
using System.Collections.Generic;

public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        List<int> luckyNumbers = new List<int>();

        int rows = matrix.Length;
        int cols = matrix[0].Length;

        // Find the minimum element in each row
        int[] minInRows = new int[rows];
        for (int i = 0; i < rows; i++) {
            int minVal = matrix[i][0];
            for (int j = 1; j < cols; j++) {
                if (matrix[i][j] < minVal) {
                    minVal = matrix[i][j];
                }
            }
            minInRows[i] = minVal;
        }

        // Check if the minimum element in each row is the maximum in its column
        for (int i = 0; i < rows; i++) {
            int minVal = minInRows[i];
            bool isMaxInCol = true;
            for (int j = 0; j < rows; j++) {
                if (matrix[j][Array.IndexOf(matrix[i], minVal)] > minVal) {
                    isMaxInCol = false;
                    break;
                }
            }
            if (isMaxInCol) {
                luckyNumbers.Add(minVal);
            }
        }

        return luckyNumbers;
    }
}

// Test cases
void TestSolution() {
    Solution solution = new Solution();

    // Test case 1
    int[][] matrix1 = new int[][] {
        new int[] { 3, 7, 8 },
        new int[] { 9, 11, 13 },
        new int[] { 15, 16, 17 }
    };
    Console.WriteLine($"Test 1: {string.Join(", ", solution.LuckyNumbers(matrix1))}");  // Expected: [15]

    // Test case 2
    int[][] matrix2 = new int[][] {
        new int[] { 1, 10, 4, 2 },
        new int[] { 9, 3, 8, 7 },
        new int[] { 15, 16, 17, 12 }
    };
    Console.WriteLine($"Test 2: {string.Join(", ", solution.LuckyNumbers(matrix2))}");  // Expected: [12]

    // Test case 3
    int[][] matrix3 = new int[][] {
        new int[] { 7, 8 },
        new int[] { 1, 2 }
    };
    Console.WriteLine($"Test 3: {string.Join(", ", solution.LuckyNumbers(matrix3))}");  // Expected: [7]
}

// Execute the test cases
TestSolution();
