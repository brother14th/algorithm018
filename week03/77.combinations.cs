/*
 * @lc app=leetcode id=77 lang=csharp
 *
 * [77] Combinations
 */

// @lc code=start
using System;
using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
     //fill in n slot
     var result=new List<IList<int>>();
      CombineHelper(new List<int>(), result,1, n, k);
      return result;
    }

    private void CombineHelper(List<int> output, List<IList<int>> result, int start, int n, int k)
    {
        if (output.Count==k)
        {
            result.Add(new List<int>(output));
            return;
        }
        for (int i = start; i <=n ;i++)
        {
            output.Add(i);
            CombineHelper(output,result,i+1,n,k);//i+1
            output.RemoveAt(output.Count-1);//faster than output.Remove(i); 
            
        }
    }
}
// @lc code=end

