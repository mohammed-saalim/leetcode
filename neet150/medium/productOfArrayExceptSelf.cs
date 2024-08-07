public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];


        left[0] = 1;
        for(int i = 1; i< nums.Length; i++){
            left[i] = left[i-1] * nums[i-1]; 
            
        }

        right[nums.Length-1] = 1;

        for(int i = nums.Length-2; i>=0; i-- ){

            right[i] = right[i+1] * nums[i+1];
        }

        for(int i=0; i < left.Length; i++){

            nums[i] = left[i] * right[i];
        }
        

        return nums;
    }
}


/*

find product of left and right array and multiply both array in result

*/