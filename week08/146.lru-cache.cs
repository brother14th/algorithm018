/*
 * @lc app=leetcode id=146 lang=csharp
 *
 * [146] LRU Cache
 */

// @lc code=start
//6.18 
using System.Collections.Generic;

public class Node
{
    public int value {set; get;}
    public Node previous {set; get;}
    public Node next {set; get;}
    public Node (int value)
    {
        this.value = value;
    }
   
}
public class CustomedLinkedList 
{
    private Node head;
    private Node tail;
    private Dictionary<int, Node> dict = new Dictionary<int,Node>();

    public Node Last 
    {
        get
        {
            if(dict.Count>0)
                return tail.previous;
             return null;
        }
    }
    public CustomedLinkedList ()
    {
       
        head = new Node(-1);
        tail = new Node(-1);
        head.next=tail;
        tail.previous=head;
    }

    public void AddFirst(int value)
    {
        var tmp = head.next;
        var newNode= new Node(value);
        head.next=newNode;
        newNode.next=tmp;
        tmp.previous=newNode;
        newNode.previous=head;
        dict.Add(value,newNode);
        
    }

    public void RemoveLast()
    {
        if(dict.Count>0)
        {
            var last = tail.previous;
            var secondLast = last.previous;
            secondLast.next=tail;
            tail.previous = secondLast; 
            dict.Remove(last.value);
        }
    }

    public void Remove(int value)
    {
        //Get node
        if(dict.ContainsKey(value))
        {

        var node = dict[value];
        var previousNode=node.previous;
        previousNode.next=node.next;
        node.next.previous = previousNode;
        //remove from dict
        dict.Remove(value);
        }
    }


}
public class LRUCache {
    private CustomedLinkedList keys = new CustomedLinkedList();
    private Dictionary<int, int> cache = new Dictionary<int,int>();

    int capacity;
    int count;
    public LRUCache(int capacity) {
        this.capacity = capacity;
        count = 0;
    }
    
    public int Get(int key) {
        if (cache.ContainsKey(key)==false) return -1;
        //remove the key
        //add key to front
        //return cache
        keys.Remove(key);
        keys.AddFirst(key);
        return cache[key];
    }
    
    public void Put(int key, int value) {
        if (cache.ContainsKey(key)==false)
        {
            //add key to front
            //add value to cache
            //check count
            keys.AddFirst(key);
            cache[key]=value;
            count++;
            if(count>capacity)
            {
                //remove last key
                //remove cache
                var last = keys.Last.value;
                keys.RemoveLast();
                cache.Remove(last);
                count--;
            }
        }
        else
        {
            //update cache
            //remove key
            //add key to front
            cache[key] = value;
            keys.Remove(key);
            keys.AddFirst(key);
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

