# 1138 - Digits Count

Diana is going to write a list of all positive integers between A and B, inclusive, in base 10 and without any leading zeros. She wants to know how many times each digit is going to be used.

**Input**<br>
Each test case is given in a single line that contains two integers **A** and **B** (1 ≤ **A** ≤ **B** ≤ 10<sup>8</sup>). The last test case is followed by a line containing two zeros.

**Output**<br>
For each test case print a single line with 10 integers representing the number of times each digit is used when writing all integers between **A** and **B**, inclusive, in base 10 and without leading zeros. Write the counter for each digit in increasing order from 0 to 9.

**Input Sample**
````
1 9
12 321
5987 6123
12345678 12345679
0 0
````

**Output Sample**
````
0 1 1 1 1 1 1 1 1 1
61 169 163 83 61 61 61 61 61 61
134 58 28 24 23 36 147 24 27 47
0 2 2 2 2 2 2 2 1 1
````