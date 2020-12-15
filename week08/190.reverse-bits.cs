/*
 * @lc app=leetcode id=190 lang=csharp
 *
 * [190] Reverse Bits
 */

// @lc code=start
public class Solution {
    public uint reverseBits(uint n) {
        //1.57 
        //extract left most bit
        int power=31;
        uint result=0;
        while(n!=0)
        {
            result+=((n&1)<<power);
            n>>=1;
            power--;
        }
        return result;
    }
}
// @lc code=end

