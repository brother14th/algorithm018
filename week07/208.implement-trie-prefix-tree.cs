/*
 * @lc app=leetcode id=208 lang=csharp
 *
 * [208] Implement Trie (Prefix Tree)
 */

// @lc code=start

 public class TrieNode
{
    public TrieNode[] children=new TrieNode[26];
    public bool isWord;
       
}
public class Trie {

   private TrieNode root;
    /** Initialize your data structure here. */
    public Trie() {
        root=new TrieNode();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        var node=root;        
        foreach (var c in word)
        {
            if(node.children[c-'a']==null)
                node.children[c-'a']=new TrieNode();
            node=node.children[c-'a'];
        }
        node.isWord=true;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        var node=root;
        foreach (var c in word)
        {
            if(node.children[c-'a']==null) 
                return false;
            node=node.children[c-'a'];
        }
        return node.isWord;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        var node=root;
        foreach (var c in prefix)
        {
            if(node.children[c-'a']==null) 
                return false;
            node=node.children[c-'a'];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
// @lc code=end

