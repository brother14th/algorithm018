/*
 * @lc app=leetcode id=641 lang=csharp
 *
 * [641] Design Circular Deque
 */

// @lc code=start
public class MyCircularDeque {

    /** Initialize your data structure here. Set the size of the deque to be k. */
    int front;
    int rear;
    int capacity;
    int count;
    int[] deque;
    public MyCircularDeque(int k) {
        front=0;
        rear=-1;
        capacity=k;
        count=0;
        deque=new int[k];
    }
    
    /** Adds an item at the front of Deque. Return true if the operation is successful. */
    public bool InsertFront(int value) {
        if (!IsFull())
        {            
            count++;
            front--;
            if (front<0)
            {
                front=capacity-1;
            }
            deque[front]=value;
            
            //take note
            if (count == 1) rear = front; 

            return true;
        }
        return false;
    }
    
    /** Adds an item at the rear of Deque. Return true if the operation is successful. */
    public bool InsertLast(int value) {
        if (!IsFull())
        {
            count++;
            rear++;
            if (rear>capacity-1)
            {
                rear=0;
            }
            deque[rear]=value;
            return true;
        }
        return false;
    }
    
    /** Deletes an item from the front of Deque. Return true if the operation is successful. */
    public bool DeleteFront() {
        if (!IsEmpty())
        {
            count--;
            front++;
            if (front>capacity-1)
            {
                front=0;
            }
            return true;
        }
        return false;
    }
    
    /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
    public bool DeleteLast() {
         if (!IsEmpty())
        {
            count--;
            rear--;
            if (rear<0)
            {
                rear=capacity-1;
            }
            return true;
        }
        return false;
    }
    
    /** Get the front item from the deque. */
    public int GetFront() {
        return IsEmpty()?-1:deque[front];
    }
    
    /** Get the last item from the deque. */
    public int GetRear() {
         return IsEmpty()?-1:deque[rear];
    }
    
    /** Checks whether the circular deque is empty or not. */
    public bool IsEmpty() {
        return count==0;
    }
    
    /** Checks whether the circular deque is full or not. */
    public bool IsFull() {
        return capacity==count;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */
// @lc code=end

