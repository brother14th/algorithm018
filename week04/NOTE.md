学习笔记

BFS

- Explore nodes horizontally

- Template

  - Add root to queue
  - Add root to visited set
  - While q!=empty
    - v=q.dequeue()
    - if v is goal return v
    - foreach v's children
      - if not visited
        - add child to q
        - add child to visited set

  

DFS

- Explore nodes vertically

- Template

  - Add root to queue

  - dfs(root)

    - if root==null return;
    - add root to visited set
    - process current node
    - foreach root's children
      - if not visited
        - dfs(child)

    

  Iteration version (Pending)

Greedy algorithm

- Making locally optimal choice at each stage



使用二分查找，寻找一个半有序数组 [4, 5, 6, 7, 0, 1, 2] 中间无序的地方

​		int start=0;
​        int end=nums.Length-1;
​        if(nums.Length==1||nums[0]<nums[end]) return nums[0];
​        while(start<end)
​        {
​            int mid=(start+end)/2;
​            if(nums[mid]<nums[end]) end=mid;
​            else start=mid+1;
​        }
​        return start;

