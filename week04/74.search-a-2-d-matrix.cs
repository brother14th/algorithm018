/*
 * @lc app=leetcode id=74 lang=csharp
 *
 * [74] Search a 2D Matrix
 */

// @lc code=start
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        //binary search

        if (matrix.Length==0) return false;
                    
        int nRow=matrix.Length;
        int nCol=matrix[0].Length;
        
        int start=0;
        int end=nRow*nCol-1;
        int mid=0;
        while (start<=end)
        {
            
             mid=(start+end)/2;
            var midElement=matrix[mid/nCol][mid%nCol];
            if (midElement==target) return true;
            else if(target>midElement) 
            {
                start=mid+1;
            }
            else
            {
                end=mid-1;
            }
        }
        return false;
    }
}
// @lc code=end

