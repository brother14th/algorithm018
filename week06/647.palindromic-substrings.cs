/*
 * @lc app=leetcode id=647 lang=csharp
 *
 * [647] Palindromic Substrings
 */

// @lc code=start
public class Solution {
    public int CountSubstrings(string s) {
        //dp[i,j]=s[i]==sj[j]&&dp[i+1,j-1]
        //if(s[i]==s[j]&&())
        if(s.Length==0) return 0;
        int nRow=s.Length;
        int nCol=s.Length;
        bool[,] palindome=new bool[nRow,nCol];
        int count=0;
        for (int j = 0; j < nCol; j++)
        {
            for (int i = 0; i <=j; i++)
            {
                if(s[i]==s[j]&&(j-i<=1||palindome[i+1,j-1]))
                {
                    palindome[i,j]=true;
                    count++;
                }
            }
        }
        return count;
    }
}
// @lc code=end

