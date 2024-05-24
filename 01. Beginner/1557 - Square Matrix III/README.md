# 1557 - Square Matrix III

Write a program that read an integer number N (0 ≤ N ≤ 15) that correspont to the order of a bidimentional array of integers, and build the array according to the above example.

**Input**<br>
The input consists of several integers numbers, one per line, corresponding to orders from arrays to be built. The end of input is indicated by zero (0).

**Output**<br>
For each integer number of input, print the corresponding array according to the example. The values ​​of the array must be formatted in a field of size **T** right justified and separated by a space, where **T** is equal to the number of digits of the biggest number in the array. None space must be printed after the last character of each row of the array. A blank line must be printed after each array.

**Sample Input**
````
1        
2        
3        
4        
5        
0        
````


**Sample Output**
````
1

1 2
2 4

1  2  4
2  4  8
4  8 16

1  2  4  8 
2  4  8 16 
4  8 16 32 
8 16 32 64

 1   2   4   8  16  
 2   4   8  16  32  
 4   8  16  32  64  
 8  16  32  64 128 
16  32  64 128 256
````