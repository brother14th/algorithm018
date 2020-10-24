/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
using System.Collections.Generic;
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //loop
        //check complement num in Hash
        //if yes return indexes
        //else add nums[i] to hash
        Dictionary<int,int> dictionary=new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement=target-nums[i];
            if (dictionary.ContainsKey(complement))
            {
                return new int[]{i,dictionary[complement]};
            }
            dictionary[nums[i]]=i;
        }
        return new int[2]{-1,-1};
    }
}
// @lc code=end

