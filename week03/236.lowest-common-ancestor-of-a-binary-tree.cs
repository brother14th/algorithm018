/*
 * @lc app=leetcode id=236 lang=csharp
 *
 * [236] Lowest Common Ancestor of a Binary Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        if (root==null||root==p||root==q)
        {
            return root;
        }
        TreeNode left=LowestCommonAncestor(root.left,p,q);
        TreeNode right=LowestCommonAncestor(root.right,p,q);
        if (left==null)
        {
            return right;
        }
        else if(right==null)
        {
            return left;
        }
        return root;

    }
     
}
// @lc code=end

