学习笔记

Dynamic programming

Break down a problem into subproblems (overlapping) 

Define state transition equation

e.g. 

fib(n)=fib(n-1)+fib(n-2)

(Longest common subsequence) 

​	if(text1[i-1]==text2[j-1]) dp[i,j]=dp[i-1,j-1]+1;
​                else dp[i,j]=Math.Max(dp[i,j-1],dp[i-1,j]);

(Minimum Path Sum)
	DP[i][j]=min(DP[i-1][j],DP[i,j-1])+grid[i,j]

(Coin change)

 	dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);