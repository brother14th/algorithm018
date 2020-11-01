/*
 * @lc app=leetcode id=347 lang=csharp
 *
 * [347] Top K Frequent Elements
 */

// @lc code=start
using System.Collections.Generic;
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        //create freq dict
        //create list<int>[] to hold numbers
        //loop dict2 from end
          //not null=> add result
       Dictionary<int,int> freqDict=new Dictionary<int, int>();
       for (int i = 0; i < nums.Length; i++)
       {
           if (freqDict.ContainsKey(nums[i]))
           {
               freqDict[nums[i]]++;
           }
           else
           {
               freqDict.Add(nums[i],1);
           }
       }
       
       List<int>[] bucket=new List<int>[nums.Length+1];
       foreach (var item in freqDict)
       {
           if(bucket[item.Value]==null)
           {
               bucket[item.Value]=new List<int>();
           }
           bucket[item.Value].Add(item.Key);
       }

       //int[] result=new int[k];
       List<int> result=new List<int>();
       for (int i = bucket.Length - 1; i >= 1 &&result.Count<k ; i--)
       {
           if (bucket[i]!=null)
           {
               result.AddRange(bucket[i]);
           }
       }

        return result.ToArray();
    }
}
// @lc code=end

