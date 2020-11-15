/*
 * @lc app=leetcode id=200 lang=csharp
 *
 * [200] Number of Islands
 */

// @lc code=start
using System;

public class Solution {
    public int NumIslands(char[][] grid) {
        
        //for row
           //for column
              //if 1
                 //land++
                 //MarkZeroes
        int nRow=grid.Length;
        int nCol=grid[0].Length;
        int land=0;
        for (int i = 0; i < nRow; i++)
        {
            for (int j = 0; j < nCol; j++)
            {
                if (grid[i][j]=='1')
                {
                    land++;
                    MarkZeroes(grid,i,j,nRow,nCol);
                }
            }
        }                 
     
     return land;
     
    }

    private void MarkZeroes(char[][] grid, int i, int j, int nRow,int nCol)
    {
        //terminate condition
        
        if (i<0||i>nRow-1||j<0||j>nCol-1||grid[i][j]=='0') return;
        
        grid[i][j]='0';
        MarkZeroes(grid,i-1,j,nRow,nCol);
        MarkZeroes(grid,i+1,j,nRow,nCol);
        MarkZeroes(grid,i,j-1,nRow,nCol);
        MarkZeroes(grid,i,j+1,nRow,nCol);
    }
}
// @lc code=end

