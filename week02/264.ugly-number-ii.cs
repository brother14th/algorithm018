/*
 * @lc app=leetcode id=264 lang=csharp
 *
 * [264] Ugly Number II
 */

// @lc code=start
using System;

public class Solution {
    public int NthUglyNumber(int n) {
        
        //Get min from array[i],array[j],array[k]
        // //advanced min index
        //use seperate if to remove duplicate
        int[] result    =new int[n];
        int index2=0;
        int index3=0;
        int index5=0;
        result[0]=1;
        for (int i = 1; i < n; i++)
        {
            int min=Math.Min(Math.Min(result[index2]*2,result[index3]*3), result[index5]*5);
            if (min==result[index2]*2)
            {
                index2++;
            }
            if (min==result[index3]*3) 
            {
                index3++;
            }
            if (min==result[index5]*5)
            {
                index5++;
            }
            result[i]=min;
        }
        return result[n-1];
    }
}
// @lc code=end

