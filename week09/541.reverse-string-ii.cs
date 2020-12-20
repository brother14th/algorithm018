/*
 * @lc app=leetcode id=541 lang=csharp
 *
 * [541] Reverse String II
 */

// @lc code=start
using System;
using System.Text;

public class Solution {
    public string ReverseStr(string s, int k) {
        char[] result = s.ToCharArray();
        for(int i=0; i<s.Length; i+=2*k)
        {
            //reverse the strings
            ReverseStr(result,i,k);
        }
      return new string(result);
    }

    private void ReverseStr(char[] result, int start, int k)
    {
       int end= Math.Min(result.Length-1, start+k-1);
       while(start<end)
       {
           char tmp = result[start];
           result[start]=result[end];
           result[end] = tmp;
           start++;
           end--;
       }
    }
}
// @lc code=end

