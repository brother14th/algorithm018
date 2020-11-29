/*
 * @lc app=leetcode id=221 lang=csharp
 *
 * [221] Maximal Square
 */

// @lc code=start
using System;

public class Solution {
    public int MaximalSquare(char[][] matrix) {
        
        if(matrix.Length==0) return 0;
        //dp[i][j]= min(dp1,dp2,dp3)+1
        int nRow=matrix.Length;
        int nCol=matrix[0].Length;
        int[,] dp =new int[nRow,nCol];
        int maxLength=0;
        for (int i = 0; i < nRow; i++)
        {
            for (int j = 0; j < nCol; j++)
            {
                if(matrix[i][j]=='1') 
                {
                    if(i==0||j==0) dp[i,j]=1;
                    else 
                        dp[i,j]=Math.Min(Math.Min(dp[i,j-1],dp[i-1,j]),dp[i-1,j-1])+1;
                    maxLength=Math.Max(maxLength,dp[i,j]);
                }
            }
        }
        return maxLength*maxLength;
    }
}
// @lc code=end

