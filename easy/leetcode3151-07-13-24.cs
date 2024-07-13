//https://leetcode.com/problems/special-array-i/

/*
3151. Special Array I

Hint
An array is considered special if every pair of its adjacent elements contains two numbers with different parity.

You are given an array of integers nums. Return true if nums is a special array, otherwise, return false.

 

Example 1:

Input: nums = [1]

Output: true

Explanation:

There is only one element. So the answer is true.

Example 2:

Input: nums = [2,1,4]

Output: true

Explanation:

There is only two pairs: (2,1) and (1,4), and both of them contain numbers with different parity. So the answer is true.

Example 3:

Input: nums = [4,3,1,6]

Output: false

Explanation:

nums[1] and nums[2] are both odd. So the answer is false.

 

Constraints:

1 <= nums.length <= 100
1 <= nums[i] <= 100


*/

public class Solution {
    public bool IsArraySpecial(int[] nums) {
        bool special = true;

         if(nums.Length==1) {return true;}

        for(int i = 0 ; i< nums.Length-1; i++){


            special = CheckSpecial(i, nums);

            if(!special) { return special;}

        }

        return special;
        
    }

    private bool CheckSpecial(int i, int[] nums){

        if(nums[i] % 2 == 0 && nums[i+1] % 2 == 0 )
            return false;

        if(nums[i] % 2 != 0 && nums[i+1] % 2 != 0)
            return false;

        return true;        

    }
}



        void TestSolution() {

        Solution solution = new Solution();

        // Test case 1
        int[] nums1 = { 1 };
        Console.WriteLine($"Test 1: {solution.IsSpecialArray(nums1)}");  // Expected: true

        // Test case 2
        int[] nums2 = { 2, 1, 4 };
        Console.WriteLine($"Test 2: {solution.IsSpecialArray(nums2)}");  // Expected: true

        // Test case 3
        int[] nums3 = { 4, 3, 1, 6 };
        Console.WriteLine($"Test 3: {solution.IsSpecialArray(nums3)}");  // Expected: false

        // Additional test cases
        int[] nums4 = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Test 4: {solution.IsSpecialArray(nums4)}");  // Expected: true

        int[] nums5 = { 2, 2, 4, 6 };
        Console.WriteLine($"Test 5: {solution.IsSpecialArray(nums5)}");  // Expected: false

        }

TestSolution();        