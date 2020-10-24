/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
       //for 
          //if nums[i]!=nums[i-1]
            //nums[count++]=nums[i]
       if (nums.Length<2)
       {
           return nums.Length;
       }
       int count=1;
       for (int i = 1; i < nums.Length; i++)
       {
           if (nums[i]!=nums[i-1])
           {
               nums[count++]=nums[i];
           }
       }
       return count;
       
    }
}
// @lc code=end

