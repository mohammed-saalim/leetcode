public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        // Approach 1
        // i + j = target 
        // j = target - i
      
        var maps = new Dictionary<int, int>();
        int j;
        for(int i =0; i< nums.Length; i++){
            j = target - nums[i];

            if(maps.ContainsKey(j)){
                return new int[] {maps[j], i};
            }

            maps[nums[i]] = i;


        }

        return new int[] {-1, -1};



        
    }
}


//approach 2 two pointer:
/*
public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        // Step 1: Store numbers with their original indices and sort them
        var indexedNums = nums
            .Select((value, index) => new { Value = value, Index = index })
            .OrderBy(x => x.Value)
            .ToArray();

        int left = 0, right = indexedNums.Length - 1;

        // Step 2: Apply Two Pointers Technique
        while (left < right) {
            int sum = indexedNums[left].Value + indexedNums[right].Value;

            if (sum == target) {
                return new int[] { indexedNums[left].Index, indexedNums[right].Index };
            } 
            else if (sum > target) {
                right--;  // Move right pointer to reduce sum
            } 
            else {
                left++;   // Move left pointer to increase sum
            }
        }

        return new int[0]; // No solution found
    }
}


*/
