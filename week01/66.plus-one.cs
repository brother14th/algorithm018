/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
public class Solution {
    public int[] PlusOne(int[] digits) {
        //loop -
        //if digits[i]<9
          //digits[i]=digits[i]+1;
          //return
        //digits[i]=0    
        //handle exception case

        int i;
        for (i = digits.Length-1; i >= 0; i--)
        {
            if(digits[i]<9)
            {
                digits[i]=digits[i]+1;
                return digits;
            }
             digits[i]=0 ;
        } 
        int[] result=new int [digits.Length+1];
        
        if (i<0)
        {
            result[0]=1;
        }
        return result;

    }
}
// @lc code=end

