// https://leetcode.com/problems/can-place-flowers/?envType=study-plan-v2&envId=leetcode-75


/*
605. Can Place Flowers
Easy
Topics
Companies
You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

 

Example 1:

Input: flowerbed = [1,0,0,0,1], n = 1
Output: true
Example 2:

Input: flowerbed = [1,0,0,0,1], n = 2
Output: false
 

Constraints:

1 <= flowerbed.length <= 2 * 104
flowerbed[i] is 0 or 1.
There are no two adjacent flowers in flowerbed.
0 <= n <= flowerbed.length

*/

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        for (int i = 0; i < flowerbed.Length; i++) {
            if (flowerbed[i] == 0 && canPlantHere(i, flowerbed)) {
                flowerbed[i] = 1;  // Plant flower
                n--;
            }

            if (n <= 0) {
                return true;
            }
        }

        return n <= 0;
    }

    private bool canPlantHere(int i, int[] flowerbed) {
        // Check left plot
        bool leftEmpty = (i == 0) || (flowerbed[i - 1] == 0);
        // Check right plot
        bool rightEmpty = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

        return leftEmpty && rightEmpty;
    }
}

void TestSolution() {
        Solution solution = new Solution();

        // Test case 1
        int[] flowerbed1 = { 1, 0, 0, 0, 1 };
        int n1 = 1;
        bool result1 = solution.CanPlaceFlowers(flowerbed1, n1);
        Console.WriteLine($"Result 1: {result1}");  // Expected: true

        // Test case 2
        int[] flowerbed2 = { 1, 0, 0, 0, 1 };
        int n2 = 2;
        bool result2 = solution.CanPlaceFlowers(flowerbed2, n2);
        Console.WriteLine($"Result 2: {result2}");  // Expected: false

        // Additional test cases can be added here
}

// Call the test function
TestSolution();
