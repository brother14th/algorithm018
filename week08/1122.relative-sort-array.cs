/*
 * @lc app=leetcode id=1122 lang=csharp
 *
 * [1122] Relative Sort Array
 */

// @lc code=start
public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        //6.30
        int[] counters = new int[1001];
        foreach (var num in arr1)
            counters[num]++;
        int index = 0;
        foreach (var num in arr2)
        {
            while(counters[num]>0)
            {
                arr1[index] = num ;
                counters[num]--;
                index++;
            }
        }
        for(int i=0; i<counters.Length;i++)
        {
            while(counters[i]>0)
            {
                arr1[index] = i ;
                counters[i]--;
                index++;
            }
        }
        return arr1;
    }
}
// @lc code=end

