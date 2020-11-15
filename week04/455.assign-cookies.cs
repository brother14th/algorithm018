/*
 * @lc app=leetcode id=455 lang=csharp
 *
 * [455] Assign Cookies
 */

// @lc code=start
using System;

public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        //sort g and s
        //for s
        Array.Sort(g);
        Array.Sort(s);
        int gI=0;
        int sI=0;
        while (gI<=g.Length-1&&sI<=s.Length-1)
        {
            if(s[sI]>=g[gI])gI++;
            sI++;
        }
        return gI;
    }
}
// @lc code=end

