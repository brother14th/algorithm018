/*
 * @lc app=leetcode id=860 lang=csharp
 *
 * [860] Lemonade Change
 */

// @lc code=start
public class Solution {
    public bool LemonadeChange(int[] bills) {
       
        int five=0;
        int ten=0;
        foreach (var bill in bills)
        {
            if(bill==5)five++;
            else if (bill==10)
            {
                if (five<0) return false;
                five--;
                ten++;
            }
            else //20
            {
                if (ten>0&&five>0) {five--;ten--;}
                else if(five>=3) five-=3;
                else return false;    
            }
        }
        return true;
    }
}
// @lc code=end

