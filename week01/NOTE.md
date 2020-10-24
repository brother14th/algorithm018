# 学习笔记



# 1. Remove duplicates from sorted array
Pseudocode
 ```
  for 1..n
   if nums[i]!=nums[i-1]
     nums[count++]=nums[i]
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

