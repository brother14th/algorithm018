/*
 * @lc app=leetcode id=55 lang=csharp
 *
 * [55] Jump Game
 */

// @lc code=start
using System;

public class Solution {

    private Boolean found=false;
    public bool CanJump(int[] nums) {
      //lastPos=nums.Length-1
      //for n--
        //if  i+nums[i]>=lastPost
           //lastPos=i

      int lastPos=nums.Length-1;
      for (int i = nums.Length - 1; i >= 0 ; i--)
      {
          if(i+nums[i]>=lastPos) lastPos=i;
      } 
       return lastPos==0;
        
    }


}
// @lc code=end

