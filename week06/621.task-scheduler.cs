/*
 * @lc app=leetcode id=621 lang=csharp
 *
 * [621] Task Scheduler
 */

// @lc code=start
using System;
using System.Collections.Generic;

public class Solution {
    public int LeastInterval(char[] tasks, int n) {
      
        //leastInterval=task.Length+idleInterval
        int[] counters=new int[26];
        foreach (var task in tasks)
            counters[task-'A']++;
        Array.Sort(counters);

        int maxValue=counters[25];
        int idleInterval=(maxValue-1)*n;    
        for (int i = 24; i >= 0 ; i--)
            idleInterval-=Math.Min(counters[i],maxValue-1);

        return idleInterval>0?tasks.Length+idleInterval:tasks.Length;
    }
}
// @lc code=end

