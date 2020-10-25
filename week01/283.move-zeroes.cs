/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 */

// @lc code=start
public class Solution {
    public void MoveZeroes(int[] nums) {
        //loop
         //if nums[i]!=0
           //swap elements

        if (nums.Length<=1)
        {
            return;
        }
        int count=0;
         for (int i = 0; i < nums.Length; i++)
         {
             if (nums[i]!=0)
             {
                  int temp=nums[count];
                  nums[count++]=nums[i];
                  nums[i]=temp;
             }
         }

    }
}
// @lc code=end