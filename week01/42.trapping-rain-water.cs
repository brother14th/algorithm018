/*
 * @lc app=leetcode id=42 lang=csharp
 *
 * [42] Trapping Rain Water
 */

// @lc code=start
using System;

public class Solution {
    public int Trap(int[] height) {
        
        if (height.Length<=2)
        {
            return 0;
        }
         
       //loop n
       //set Left[i]

       //loop n 
       // set right[i]

       //loop n 
         //water+=min(max left i, max right i)
       int n=height.Length;
       int[] left=new int[n];
       int[] right=new int[n];
       int water=0;
       left[0]=height[0];
       for (int i = 1; i < n; i++)
       {
           left[i]=Math.Max(height[i],left[i-1]);
       }
       right[n-1]=height[n-1];
       for (int i = n-2; i >= 0; i--)
       {
           right[i]=Math.Max(height[i],right[i+1]);
       }
       for (int i = 0; i < n; i++)
       {
           water+=Math.Min(left[i],right[i])-height[i];
       }
       return water;
    }
}
// @lc code=end

