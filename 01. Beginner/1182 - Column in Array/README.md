# 1182 - Column in Array

Your job in this problem is to read a number that is a column of an array where an operation will be performed, an uppercase character, indicating the operation to be performed and all elements of a bidimentional array **M**[12][12]. Then, you have to calculate and print the sum or average of all elements within the green area according to the case. The following figure illustrates the case when is entered the number 5 to the array column, showing all elements that must be considered in the operation.

![1182_ColumnInArray.webp](https://github.com/ricrochads/beecrowd-solutions/blob/main/01.%20Beginner/1182%20-%20Column%20in%20Array/1182_ColumnInArray.webp)

**Input**<br>
The first line of the input contains a simple integer **C** (0 ≤ **C** ≤ 11) indicating the column to be considered in the operation. The second line of the input contains a single uppercase character T ('S' or 'M'), indicating the operation Sum or Average (Média in portuguese) to be performed with the elements of the array. Follow 144 floating-point numbers of the array.

**Output**<br>
Print the calculated result (sum or average), with one digit after the decimal point.

**Input Sample**
````
5 
S 
1.0 
-3.5 
2.5 
4.1 
...
````

**Output Sample**
````
12.6
````