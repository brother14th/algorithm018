/*
 * @lc app=leetcode id=127 lang=csharp
 *
 * [127] Word Ladder
 */

// @lc code=start
using System.Collections.Generic;

public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {

       //2.11
       //bi bfs
       //init beginset, endset
       //while beginset !empty
          //for word in beginset
             //if == endword return level
             //else
               //get adjacent word
          //set beginset and endset

        if(wordList.Contains(endWord)==false) return 0;
        HashSet<string> beginSet=new HashSet<string>();  
        HashSet<string> endSet=new HashSet<string>();
        HashSet<string> visitedSet=new HashSet<string>();
        HashSet<string> wordSet=new HashSet<string>(wordList);
        beginSet.Add(beginWord);
        endSet.Add(endWord);
        int level=2;
        while(beginSet.Count>0)
        {
            HashSet<string> newSet=new HashSet<string>();
            foreach(var word in beginSet)
            {
                //if(endSet.Contains(word)) return level; //take note
                for(int i=0;i<word.Length;i++)
                {
                    char[] newWord=word.ToCharArray();
                    for(char j='a';j<='z';j++)
                    {
                        if(j==word[i]) continue;
                        newWord[i]=j;
                        string newWordString=new string(newWord);
                        if(endSet.Contains(newWordString)) return level; //take note
                        if(wordSet.Contains(newWordString)&&visitedSet.Add(newWordString)) 
                            newSet.Add(newWordString);
                    }
                }
            }
            if(newSet.Count<endSet.Count) beginSet=newSet;
            else 
            {
                beginSet=endSet;
                endSet=newSet;
            }
            level++;
        }
        return 0;
    }
}
// @lc code=end

