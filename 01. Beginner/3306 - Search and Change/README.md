# 3306 - Search and Change

Given a vector with N elements, answer Q queries of types:

1 A B V: Add V across all elements from position A to position B of the vector.

2 A B: Returns the Greatest Common Divisor of all elements from positions A to B in the vector

**Input**<br>
The input consists of several test cases. The first line of each test case contains two integers **N** **Q**, representing respectively the vector size and the number of queries. The second line of input contains **N** integers representing the elements of the vector. The next **Q** lines contain the queries as described above.

Limits:

1 ≤ **N**; **Q** ≤ 10<sup>5</sup>

**Output**<br>
For each type 2 query print the GCD of all vector positions that are in the AB range

**Input Samples**
```
7 4
1 8 4 16 6 13 20
2 2 4
2 5 7
1 5 7 1
2 5 7
```
```
5 1
4 6 8 10 12
2 1 5
```

**Output Samples**
```
4
1
7
```
```
2
```