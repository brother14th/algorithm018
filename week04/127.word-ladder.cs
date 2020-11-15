/*
 * @lc app=leetcode id=127 lang=csharp
 *
 * [127] Word Ladder
 */

// @lc code=start
using System;
using System.Collections.Generic;

public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        //create adjacentMap
        //BFS
        Dictionary<String, List<String>> adjacentMap=new Dictionary<string, List<string>>();
        foreach (var word in wordList)
        {
            for (int i = 0; i < word.Length; i++)
            {
                var key=word.Substring(0,i)+"*"+word.Substring(i+1);
                if (!adjacentMap.ContainsKey(key))
                    adjacentMap[key]=new List<string>();
                adjacentMap[key].Add(word);
            }
        }
        
        HashSet<string> visited=new HashSet<string>();
        Queue<Tuple<String,int>> queue=new Queue<Tuple<string, int>>();
        queue.Enqueue(new Tuple<String,int>(beginWord,1));
        visited.Add(beginWord);
        while (queue.Count>0)
        {
            //pop node
            //marked visited
            //if ==, return
            //else
            //Get adjacent nodes
             // 
            (string word, int level)=queue.Dequeue();
            if (word==endWord) return level;
            for (int i = 0; i < word.Length; i++)
            {
                var key=word.Substring(0,i)+"*"+word.Substring(i+1);
                if(adjacentMap.ContainsKey(key))
                {
                    foreach (var adjacent in adjacentMap[key])
                    {
                        if (visited.Add(adjacent)) //not visited
                        {
                            if(word==adjacent) return level+1;
                            queue.Enqueue(new Tuple<string, int>(adjacent,level+1));    
                        }
                    }
                }
            }
        }

        return 0;
        

    }
}
// @lc code=end

