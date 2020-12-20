学习笔记



Best Time to Buy and Sell Stock generic solution

```
dp[i][k][0 or 1]
0 <= i <= n-1, 1 <= k <= K
n 为天数，大 K 为最多交易数
此问题共 n × K × 2 种状态，全部穷举就能搞定。

for 0 <= i < n:
    for 1 <= k <= K:
        for s in {0, 1}:
            dp[i][k][s] = max(buy, sell, rest)

```

https://www.cnblogs.com/hanyuhuang/p/11083384.html



String matching algorithms

**<u>Rabin-Karp</u>**

use hash function to perform approximate check for each position.

compare the whole pattern only when hash(pattern) = hash(substring)

https://www.youtube.com/watch?v=H4VrKHVG5qI



**<u>KMP</u>**

https://www.educative.io/edpresso/what-is-the-knuth-morris-pratt-algorithm







