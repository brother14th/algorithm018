/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        //while (i>=0 &&j>=0) 
          //if nums[i]>nums[j]
            //move nums[i] to tail
          //else
             // move nums[j] 
        //tail++    
       //move remaining nums2 elements
       int i=m-1;
       int j=n-1;
       int tail=m+n-1;
       while (i>=0&&j>=0)
       {
           if (nums1[i]>nums2[j])
           {
               nums1[tail--]=nums1[i];;
               i--;
           }else
           {
                nums1[tail--]=nums2[j];;
                j--;
           }
       } 
        while (j>=0)
        {
            nums1[j]=nums2[j];
            j--;
        }
    }
}
// @lc code=end

