# 学习笔记

1. Practise same question at least 5 times  
    
2. Data structure
    + Linear 
        + Arrary
        + Linked List
        + Stack
        + Queue
        + Dictionary/Hash table?
    + Non-linear
        +   Tree
        +   Graph
3. Algorithm
   + if else
   + for loop
   + recursive 
   
4. Common Time Complexity [Table](https://www.bigocheatsheet.com/)
   + O(1)
   + O(log n)
    example?
   + O(n)
   + O(nlogn)
        ```
        for (int i=0; i<n; i=i*2)
        {
            
        }
        ````
   + O(n^2)
   + O(2 ^n)
        ```
        int fib(int n)
        {
            if(n<2) return n;
            return fib(n-1)+fib(n-2)
        }
        ```
   + O(n!) 

5. Master Theorem?
    + [Application to common algorithms](https://en.wikipedia.org/w/index.php?title=Master_theorem_(analysis_of_algorithms))

6. Problem solving approach
    + Clarification
    + Identify posibble solutions
        + Break problem into smaller unit
            + Bruteforce
            + ... 
    + Compare complexity
    + Coding
    + Testing with key test cases



# 1. Remove duplicates from sorted array
Pseudocode
 ```
  for 1..n
   if nums[i]!=nums[i-1]
     nums[count++]=nums[i]
```
# 2 Rotate Array
Pseudocode
 ```
 k=k%nums.Length
 reverse all
 reverse 0..k-1 
 reverse remaining
 ```
# 3.  Merge Two Sorted Lists
Pseudocode
```
while l1!=null && l2 !=null
          if l2.val>l1.val
            tail.next=l1
             l1=l1.next
             tail=tail.next
          same thing for l2
combine list (point tail.next to the list !=null)
```

# 4. Merge Sorted Array
Pseudocode
```
while (i>=0 &&j>=0) 
    if nums[i]>nums[j]
        move nums[i] to tail
    else
       move nums[j] 
    tail++    
move remaining nums2 elements
```

# 5. Two Sum
Pseudocode
```
  loop
    check complement num in Hash
     if yes return indexes
     else add nums[i] to hash
```
# 6 Move Zeroes
Pseudocode
```
 loop
    if nums[i]!=0
      swap elements
```

# 7 Plus one
Pseudocode
```
 loop -
    if digits[i]<9
        digits[i]=digits[i]+1;
        return
    digits[i]=0    
handle exception case
```
# 8 Design Circular Deque
Take note: 
InserFront
  if (count == 1) rear = front; 
# 9 Trapping Rain Water
Pseudocode
```
 loop n
  set Left[i]
 loop n 
   set right[i]
  loop n 
    water+=min(max left i, max right i)
//Note: `Space complexity=O(n). This solution can be furhter optimized.    
``
