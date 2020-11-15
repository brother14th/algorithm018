/*
 * @lc app=leetcode id=33 lang=csharp
 *
 * [33] Search in Rotated Sorted Array
 */

// @lc code=start
public class Solution {
    public int Search(int[] nums, int target) {
        //binary search
        int start=0;
        int end=nums.Length-1;
        int mid=0;
        while (start<=end)
        {
            mid=(start+end)/2;
            if(nums[mid]==target) return mid;
            //mid in larger section
            if(nums[start]<=nums[mid])
            {
                if(nums[start]<=target&&target<nums[mid]) end=mid-1;
                else start=mid+1;
            }
            else //mid in smaller section
            {
                if(nums[mid]<target&&target<=nums[end]) start=mid+1;
                else end=mid-1;
            }
        }
        return -1;
    }
}
// @lc code=end

