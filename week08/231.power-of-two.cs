/*
 * @lc app=leetcode id=231 lang=csharp
 *
 * [231] Power of Two
 */

// @lc code=start
public class Solution {
    public bool IsPowerOfTwo(int n) {
        //0,1,2,3,4
        //1,2,4,8,16
        //clear left most 1 bit
        if(n <= 0) return false;
        return (n&(n-1)) == 0? true:false;
    }
}
// @lc code=end

