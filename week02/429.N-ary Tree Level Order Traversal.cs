/*
 * @lc app=leetcode id=429 lang=csharp
 *
 * [429] N-ary Tree Level Order Traversal
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

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        //use queue to explorer level 
            //while exploring add children to queue
        
        if(root==null)
            return new List<IList<int>>();
        
        Queue<Node> queue=new Queue<Node>();
        queue.Enqueue(root);
        IList<IList<int>> result=new List<IList<int>>();
        while (queue.Count>0)
        {
            List<int> levelResult=new List<int>();
            int len= queue.Count;
            for (int i = 0; i < len; i++)
            {
                Node node=queue.Dequeue();
                levelResult.Add(node.val);
                foreach (var item in node.children)
                {
                    queue.Enqueue(item);
                }
            }
            result.Add(levelResult);
        }
        return result;
    }
}
// @lc code=end

