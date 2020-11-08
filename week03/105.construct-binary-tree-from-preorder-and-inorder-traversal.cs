/*
 * @lc app=leetcode id=105 lang=csharp
 *
 * [105] Construct Binary Tree from Preorder and Inorder Traversal
 */

// @lc code=start

using System;
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
    Dictionary<int,int> inorderDict=new Dictionary<int, int>();
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
      //use preorder to build
      //use inorder to determine left subtree,right subtree
      //create dict for inorder
      for (int i = 0; i < inorder.Length; i++)
      {
        inorderDict[inorder[i]]=i; 
      } 
      TreeNode result=BuildTreeHelper(preorder,0,preorder.Length-1,0,inorder.Length-1);

      return result;

    }

    private TreeNode BuildTreeHelper(int[] preorder, int preLeft, int preRight, int inLeft, int inRight)
    {
        if (preLeft>preRight)
        {
            return null;
        }
        TreeNode root=new TreeNode(preorder[preLeft]);
        int inorderIndex=inorderDict[root.val];
        int length=inorderIndex-inLeft;

        root.left=BuildTreeHelper(preorder,preLeft+1,preLeft+length,inLeft,inorderIndex-1);
        root.right=BuildTreeHelper(preorder,preLeft+length+1,preRight,inorderIndex+1,inRight);
        return root;

    }
}
// @lc code=end

