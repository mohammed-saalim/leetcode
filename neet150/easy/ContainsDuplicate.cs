public class Solution {
    public bool ContainsDuplicate(int[] nums) {


//  approach 1

        // if(nums.Length<=0){
        //     return false;
        // }

        // var hashmap = new List<int>();
        // foreach(int i in nums){

        //     if(hashmap.Contains(i)){
        //         return true;
        //     }

        //     hashmap.Add(i);

        // }

        // return false;

// approach 2: HashSet<> : it doesnt contain duplicates.

    var hashset = new HashSet<int>();

    foreach(int i in nums){
        if(hashset.Add(i)){
            continue;

        }
        return true;
    }

    return false;


// approach 3: nums.Distinct().Count() == nums.Length() (slow code)

//    return nums.Distinct().Count() != nums.Length;


    }
}
