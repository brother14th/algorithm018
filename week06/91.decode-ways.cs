/*
 * @lc app=leetcode id=91 lang=csharp
 *
 * [91] Decode Ways
 */

// @lc code=start
public class Solution {
    public int NumDecodings(string s) {
        //10.45
        //if s[i]==0
          //if s[i-1]==1,2 
             //dp[i]=dp[i-2]
           //else return 0
          //else if (s[i-1]==1||(s[i-1]==2&&s[i]>=1&&s[i]<=6))
             //dp[i]=dp[i-1]  +dp[i-2]
          //else
             //dp[i]=dp[n-1]

        if(s.Length>=0&&s[0]=='0') return 0;
        int max=1;
        int first=1; 
        int second=1; 
        for (int i = 1; i < s.Length; i++)
        {
            if(s[i]=='0')
            {
                if(s[i-1]=='1'||s[i-1]=='2')
                    max=first;
                else return 0;    
            }
             else if (s[i-1]=='1'||(s[i-1]=='2'&&s[i]>='1'&&s[i]<='6'))
                  max=first+second;  
             else
                 max=second;                
             
             first=second;
             second=max;
        }
        return max;   
    }

}
// @lc code=end

