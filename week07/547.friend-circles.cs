/*
 * @lc app=leetcode id=547 lang=csharp
 *
 * [547] Friend Circles
 */

// @lc code=start
public class UnionFind
{
    public int[] Parent {get; set; }
    public int[] Rank {get; set; }
    public int Count {get; set; }
    public UnionFind(int n)
    {
        Parent=new int[n];
        Rank=new int[n];
        Count=n;
        for (int i = 0; i < n; i++)
        {
            Parent[i]=i;
        }
    }
    public void Union(int i, int j)
    {
        int parent1=Find(i);
        int parent2=Find(j);
        if(parent1==parent2) return;
        if(Rank[parent1]>Rank[parent2]) Parent[parent2]=parent1;
        else Parent[parent1]=parent2;
        Count--;
    }

    public int Find(int n)
    {
        if(n==Parent[n]) return n;
        while (Parent[n]!=n)
        {
            Parent[n]=Parent[Parent[n]]; //path compression
            n=Parent[n];
        }
        return n;
    }
}
public class Solution {
    public int FindCircleNum(int[][] M) {
        UnionFind unionFind=new UnionFind(M.Length);
        for (int i = 0; i < M.Length; i++)
        {
            for (int j = i+1; j < M.Length; j++)
            {
                if(M[i][j]==1)
                    unionFind.Union(i,j);
            }
        }
        return unionFind.Count;
    }
}
// @lc code=end

