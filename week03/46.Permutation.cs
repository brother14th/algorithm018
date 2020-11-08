/*
 * @lc app=leetcode id=46 lang=csharp
 *
 * [46] Permutations
 */

// @lc code=start
using System;
using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
      //fill in n slot , create output=nums and swap 
      IList<IList<int>> result=new List<IList<int>>();
      List<int> output=new List<int>(nums);
      int first=0;
      PermuteHelper(nums.Length, output, first,result);
      return result;
    }

    private void PermuteHelper(int length, List<int> output, int first, IList<IList<int>> result)
    {
        //terminator
        if (first==length-1) 
        {
            var tmpResult=new List<int>(output);
            result.Add(tmpResult);
            return;
        }

        for (int i = first; i < length; i++)
        {

            Swap(output,first,i);
            PermuteHelper(length,output,first+1,result);
            Swap (output, first, i);
        }
    }

    private void Swap(List<int> output, int indexA, int indexB)
    {
        int tmp=output[indexA];
        output[indexA]=output[indexB];
        output[indexB]=tmp;
    }
}
// @lc code=end

