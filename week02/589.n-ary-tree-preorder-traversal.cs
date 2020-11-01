/*
 * @lc app=leetcode id=589 lang=csharp
 *
 * [589] N-ary Tree Preorder Traversal
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

using System;
using System.Collections.Generic;

public class Solution {
    public IList<int> Preorder(Node root) {
      
      //use stack to traverse
      //push from right to left
      if (root==null)
      {
          return new List<int>();
      }
      List<int> result=new List<int>();
      Stack<Node> stack=new Stack<Node>();
      stack.Push(root);
      while (stack.Count>0)
      {
          Node popped=stack.Pop();
          result.Add(popped.val);
          if (popped.children!=null)
          {
              for (int i = popped.children.Count - 1; i >= 0 ; i--)
              {
                  stack.Push(popped.children[i]);
              }
          }
      }
       return result;
    }

   
}
// @lc code=end

