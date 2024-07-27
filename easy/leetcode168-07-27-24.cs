/*

168. Excel Sheet Column Title
Solved
Easy
Topics
Companies
Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...
 

Example 1:

Input: columnNumber = 1
Output: "A"
Example 2:

Input: columnNumber = 28
Output: "AB"
Example 3:

Input: columnNumber = 701
Output: "ZY"
 

Constraints:

1 <= columnNumber <= 231 - 1

*/

using System;
using System.Text;

public class Solution {
    public string ConvertToTitle(int columnNumber) {
        StringBuilder result = new StringBuilder();

        while (columnNumber > 0) {
            columnNumber--;  // Adjust for 1-based indexing
            int remainder = columnNumber % 26;
            char letter = (char)(remainder + 'A');
            result.Append(letter);
            columnNumber /= 26;
        }

        
        StringBuilder reversedResult = new StringBuilder(result.Length);
        for (int i = result.Length - 1; i >= 0; i--) {
            reversedResult.Append(result[i]);
        }

        return reversedResult.ToString();
    }
}

// Test cases
void TestSolution() {
    Solution solution = new Solution();


    int columnNumber1 = 1;
    Console.WriteLine($"Test 1: {solution.ConvertToTitle(columnNumber1)}");  // Expected: "A"


    int columnNumber2 = 28;
    Console.WriteLine($"Test 2: {solution.ConvertToTitle(columnNumber2)}");  // Expected: "AB"

}

// Execute the test cases
TestSolution();
