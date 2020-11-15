/*
 * @lc app=leetcode id=126 lang=csharp
 *
 * [126] Word Ladder II
 */

// @lc code=start
using System.Collections.Generic;

public class Solution {
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList) {
        
        IList<IList<string>> result=new List<IList<string>>();
        Queue<List<string>> queue=new Queue<List<string>>();
        HashSet<string> visited=new HashSet<string>();
        queue.Enqueue(new List<string>(){beginWord});
        Dictionary<string,List<string>> dict=new Dictionary<string, List<string>>();
        foreach (var word in wordList)
        {
            for (int i = 0; i < word.Length; i++)
            {
                var key=word.Substring(0,i)+"*"+word.Substring(i+1);
                if(!dict.ContainsKey(key)) dict[key]=new List<string>();
                dict[key].Add(word);
            }
        }
        bool found=false;
        //bfs
        while(queue.Count>0)
        {
            int levelCount=queue.Count;
            HashSet<string> tmpVisited=new HashSet<string>();
            for (int i = 0; i < levelCount; i++)
            {
                 //get path
                 //if peek last element==endword
                    //add result

                 //if not found
                   //Get adjacents
                   //add subvisited   

                 var path=queue.Dequeue();
                 var tmpLastWord=path[path.Count-1];
                 if(tmpLastWord==endWord)
                 {
                     found=true;
                     result.Add(path);
                 }else
                 {
                     var adjacents=GetAdjacents(tmpLastWord,dict); 
                     foreach (var adjacent in adjacents)
                     {
                         if(!visited.Contains(adjacent))
                         {
                             //create new path
                             var newPath=new List<string>(path);
                             newPath.Add(adjacent);
                             tmpVisited.Add(adjacent);
                             queue.Enqueue(newPath);
                         }
                     }
                 }
            }
            if(found) break;
            //add visited
           
            foreach (var item in tmpVisited)
            {
                visited.Add(item);
            }
        }
        return result;
    }

    private List<string> GetAdjacents(string tmpLastWord,Dictionary<string, List<string>>dict)
    {
         var adjacents=new List<string>();
         for (int i = 0; i < tmpLastWord.Length; i++)
        {
           var key=tmpLastWord.Substring(0,i)+"*"+tmpLastWord.Substring(i+1);
           if(dict.ContainsKey(key)) adjacents.AddRange(dict[key]);
        }
        return adjacents;
    }
}
// @lc code=end

