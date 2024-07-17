// 3194. Minimum Average of Smallest and Largest Elements


using System;
using System.Collections.Generic;

public class Solution {
    public double MinimumAverage(int[] nums) {
        Array.Sort(nums);
        List<double> averages = new List<double>();
        
        int left = 0;
        int right = nums.Length - 1;
        
        while (left < right) {
            double avg = (nums[left] + nums[right]) / 2.0;
            averages.Add(avg);
            left++;
            right--;
        }
        
        return averages.Min();
    }
}