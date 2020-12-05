学习笔记

Trie

- ​    prefix tree.
- ​    a type of search tree
- ​    node stores partial key
-   Template (pending)



UnionFind

	- stores a collection of disjoint sets
 - operations
   	- MakeSet
   	- Union
   	- Find

Bidirectional BFS 

- Run two BFS 
  - One starts from initial state
  - The other one starts from the goal

Template

		beginSet={initial node}
	
	    endSet={end node}
	
		level=2;
	
		While(beginSet != empty)
	
			newSet={}
	
			 foreach node in beginSet               
	
	                    foreach adjacent node
	
	                                if adjacent node in endSet  return level/result
	
	                                else
	
											if (adjacent node not visited) add adjacent node to newSet
	
				if (newSet.Count<endSet.Count) beginSet=newSet
	
				else 
	
					 beginSet=endSet
	
					endSet=newSet	
	
	 	 level++;