/*
 * @lc app=leetcode id=64 lang=csharp
 *
 * [64] Minimum Path Sum
 */

// @lc code=start
using System;

public class Solution {
    public int MinPathSum(int[][] grid) {
      //dp[i][j]=min (dp[i-1][j],dp[i][j-1])+grid[i][j]
      int nRow=grid.Length;
      int nCol=grid[0].Length;
      int[,] minPath=new int[nRow,nCol];
      for (int i = 0; i < nRow; i++)
      {
          for (int j = 0; j < nCol; j++)
          {
              if(i==0&&j==0) minPath[i,j]=grid[i][j];
              else if(i==0&&j>0) minPath[i,j]= minPath[i,j-1]+grid[i][j];
              else if (j==0) minPath[i,j]= minPath[i-1,j]+grid[i][j];
              else minPath[i,j]= Math.Min(minPath[i-1,j],minPath[i,j-1])+grid[i][j];
          }
      }
      return minPath[nRow-1,nCol-1];
    }
}
// @lc code=end

