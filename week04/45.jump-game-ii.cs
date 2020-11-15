/*
 * @lc app=leetcode id=45 lang=csharp
 *
 * [45] Jump Game II
 */

// @lc code=start
using System;

public class Solution {
    private int result=int.MaxValue;
    public int Jump(int[] nums) {
       
        int curEnd=0;
        int fartest=0;
        int jump=0;
        for (int i = 0; i < nums.Length-1; i++)
        {
            
            if(i+nums[i]>fartest) fartest=i+nums[i];
            if(i==curEnd)
            {
                jump++;
                curEnd=fartest;
            }
            
        }

        return jump;
    }

   
}
// @lc code=end

