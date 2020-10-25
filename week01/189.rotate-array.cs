/*
 * @lc app=leetcode id=189 lang=csharp
 *
 * [189] Rotate Array
 */

// @lc code=start
using System;

public class Solution {
    public void Rotate(int[] nums, int k) {
        //k=k%nums.Length
        //reverse n
        //reverse k 
        //reverse remaining
        k=k%nums.Length;
        int n=nums.Length;
        Reverse(nums,0,n-1);
        Reverse(nums,0,k-1);
        Reverse(nums,k,n-1);
        
    }

    private void Reverse(int[] nums, int start, int end)
    {
         while(start<end)
         {
             //swap elements
             int tmp=nums[start];
             nums[start]=nums[end];
             nums[end]=tmp;
             start++;
             end--;
         }
    }
}
// @lc code=end

