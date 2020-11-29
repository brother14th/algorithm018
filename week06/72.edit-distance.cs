/*
 * @lc app=leetcode id=72 lang=csharp
 *
 * [72] Edit Distance
 */

// @lc code=start
using System;

public class Solution {
    public int MinDistance(string word1, string word2) {
        //if(word1[i]==word2[j]) dp[i,j] = dp[i-1,j-1];
        //else Max(insert,update,delete)+1
           //update => dp[i-1,j-1]
           //insert => dp[i,j-1]
           //delete => dp[i-1,j]
        int[,] minOp=new int[word1.Length+1,word2.Length+1];
        for (int i = 0; i <= word1.Length; i++)
        {
            for (int j = 0; j <= word2.Length; j++)
            {
                if(i==0&&j==0) minOp[i,j]=0;
                else if(i==0&&j>0) minOp[i,j]=minOp[i,j-1]+1;
                else if(j==0&&i>0) minOp[i,j]=minOp[i-1,j]+1;
                else //i>0&&j>0
                {
                    if(word1[i-1]==word2[j-1]) //take note
                        minOp[i,j]=minOp[i-1,j-1];
                    else 
                       minOp[i,j]= Math.Min(Math.Min(minOp[i-1,j-1],minOp[i,j-1]),minOp[i-1,j])+1;
                }
            }
        }
         return minOp[word1.Length,word2.Length];
    }
}
// @lc code=end

