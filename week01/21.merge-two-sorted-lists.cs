/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        
        //while l1!=null && l2 !=null
          //if l2.val>l1.val
            //tail.next=l1
             //l1=l1.next
             //tail=tail.next
          //same thing for l2
          //combine remaining if either list is null
          ListNode dummyHead=new ListNode(0);
          ListNode tail=dummyHead; 
          while (l1!=null&&l2!=null)
          {
              if(l2.val>l1.val)
              {
                tail.next=l1;
                l1=l1.next;
              }else
              {
                tail.next=l2;
                l2=l2.next;
              }
              tail=tail.next;
          }  
          tail.next=l1==null?l2:l1; 
          return dummyHead.next;
    } 
}
// @lc code=end

