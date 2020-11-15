/*
 * @lc app=leetcode id=153 lang=csharp
 *
 * [153] Find Minimum in Rotated Sorted Array
 */

// @lc code=start
public class Solution {
    public int FindMin(int[] nums) {
        //binary search
        int start=0;
        int end=nums.Length-1;
        if(nums.Length==1||nums[0]<nums[end]) return nums[0];
        while(start<end)
        {
            int mid=(start+end)/2;
            if(nums[mid]<nums[end]) end=mid;
            else start=mid+1;
        }
        return nums[start];
    }
}
// @lc code=end

