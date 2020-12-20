/*
 * @lc app=leetcode id=300 lang=csharp
 *
 * [300] Longest Increasing Subsequence
 */

// @lc code=start
using System;

public class Solution {
    public int LengthOfLIS(int[] nums) {
     //init dp[i] to 1
     //dp[i]= max(dp[j]) +1 => nums[i>nums[j]

     int[] localMax = new int[nums.Length];
     localMax[0]=1;
     int max = 1;
     for(int i=1; i<nums.Length; i++)
     {
        localMax[i] = 1; 
        for(int j=0; j<i; j++)
        {
           if(nums[i]>nums[j])
              localMax[i] = Math.Max(localMax[j]+1,localMax[i]);
        }
        max = Math.Max(max,localMax[i]);
     }
      return max;

    }
}
// @lc code=end

