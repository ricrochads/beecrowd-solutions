# 1178 - Array Fill III

Read a number **X**. Put this **X** at the first position of an array **N** [100]. In each subsequent position (1 up to 99) put half of the number inserted at the previous position, according to the example below. Print all the vector **N**.

**Input**<br>
The input contains a double precision number with four decimal places.

**Output**<br>
For each position of the array **N** print "**N[i] = Y**", where **i** is the array position and **Y** is the number stored in that position. Each number of **N**[...] must be printed with 4 digits after the decimal point.

**Input Sample**
````
200.0000
````

**Output Sample**
````
N[0] = 200.0000 
N[1] = 100.0000 
N[2] = 50.0000 
N[3] = 25.0000 
N[4] = 12.5000 
...
````