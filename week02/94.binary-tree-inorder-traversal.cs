/*
 * @lc app=leetcode id=94 lang=csharp
 *
 * [94] Binary Tree Inorder Traversal
 */

// @lc code=start

using System.Collections.Generic;
/**
* Definition for a binary tree node.
* public class TreeNode {
*     public int val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
*         this.val = val;
*         this.left = left;
*         this.right = right;
*     }
* }
*/
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        //build left most nodes in tree
        //use current to travese
            //current=pop 
            //add to result
            //current=popped.next
        List<int> result=new List<int>();
        TreeNode current=root;
        Stack<TreeNode> stack=new Stack<TreeNode>();
        while (current!=null||stack.Count>0)
        {
             while(current!=null)
             {
                 stack.Push(current);
                 current=current.left;
             }
             current=stack.Pop();
             result.Add(current.val);
             current=current.right;
        }  
        return result;
    }
}
// @lc code=end

