/*
 * @lc app=leetcode id=32 lang=csharp
 *
 * [32] Longest Valid Parentheses
 */

// @lc code=start
using System;
using System.Collections.Generic;

public class Solution {
    public int LongestValidParentheses(string s) {
       
        //s[i]=)
            //s[i-1] =(
               //dp[i]= dp[i-2] +2
            //else 
                //if s[i- dp[i-1]-1] =( 
                    //dp[i] = dp[i-1]+2 +dp[i- dp[i-1]-1-1] 
        int[] dp = new int[s.Length];
        int max = 0;
        for(int i=1; i<s.Length; i++)
        {
            if(s[i]==')')
            {
                if(s[i-1]=='(')
                {
                    dp[i] = i-2>=0?dp[i-2]+2:2;
                }
                else if((i- dp[i-1]-1)>=0&&(s[i- dp[i-1]-1]=='('))
                {
                    dp[i]= dp[i-1]+2+(i-dp[i-1]-2>=0?dp[i-dp[i-1]-2]:0);
                }
                max = Math.Max(max,dp[i]);
            }

        }
        return max;
    }
}
// @lc code=end

