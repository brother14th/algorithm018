/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
using System.Collections.Generic;

public class Solution {
    public bool IsAnagram(string s, string t) {
        
        //use array to track freq
        //loop 
          //++
          //--
        if (s.Length!=t.Length)
        {
            return false;
        }
        int[] counters=new int[26];
       
        for (int i = 0; i < s.Length; i++)
        {
            counters[s[i]-'a']++;
            counters[t[i]-'a']--;
        }  
        
        foreach (var counter in counters)
        {
            if (counter!=0)
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

