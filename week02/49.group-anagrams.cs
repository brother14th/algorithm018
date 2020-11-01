/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams
 */

// @lc code=start
using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
       //for strs
        //compute freq string
        //add to dict
        Dictionary<string,IList<string>> dict = new Dictionary<string, IList<string>>();
        
        foreach (var str in strs)
        {
            int[] freq=new int[26];
            foreach (var c in str)
            {
                freq[c-'a']++;
            }
            
            StringBuilder freqStr=new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                freqStr.Append(freq[i]);
                freqStr.Append("#");
            }

            if (!dict.ContainsKey(freqStr.ToString()))
            {
                dict.Add(freqStr.ToString(),new List<string>());    
            }
            dict[freqStr.ToString()].Add(str);
        }
        
        return new List<IList<string>>(dict.Values);
        
    }
}
// @lc code=end

