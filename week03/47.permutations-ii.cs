/*
 * @lc app=leetcode id=47 lang=csharp
 *
 * [47] Permutations II
 */

// @lc code=start
using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
            //sort array
            //build output one by one
            //use visited to remove duplicate
            
            Array.Sort(nums);
            IList<IList<int>> result=new List<IList<int>>();
            PermuteHelper(nums,new Boolean[nums.Length],new List<int>(),result);

            return result;
      }

    private void PermuteHelper(int[] nums, bool[] visited, List<int> output, IList<IList<int>> result)
    {
        //terminate
        if (output.Count==nums.Length)
        {
            result.Add(new List<int>(output));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (visited[i]) continue;
            if (i>0&&nums[i]==nums[i-1]&&!visited[i-1]) continue; 
            output.Add(nums[i]);
            visited[i]=true;
            PermuteHelper(nums,visited,output,result);
            visited[i]=false;
            output.RemoveAt(output.Count-1);
        }
    }
}
// @lc code=end

