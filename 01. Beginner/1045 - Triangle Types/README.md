# 1045 - Triangle Types

Read 3 double numbers (A, B and C) representing the sides of a triangle and arrange them in decreasing order, so that the side A is the biggest of the three sides. Next, determine the type of triangle that they can make, based on the following cases always writing an appropriate message:

- if A ≥ B + C, write the message: **NAO FORMA TRIANGULO**
- if A^2 = B^2 + C^2, write the message: **TRIANGULO RETANGULO**
- if A^2 > B^2 + C^2, write the message: **TRIANGULO OBTUSANGULO**
- if A^2 < B^2 + C^2, write the message: **TRIANGULO ACUTANGULO**
- if the three sides are the same size, write the message: **TRIANGULO EQUILATERO**
- if only two sides are the same and the third one is different, write the message: **TRIANGULO ISOSCELES**

**Input**<br>
The input contains three double numbers, A (0 < A) , B (0 < B) and C (0 < C).

**Output**<br>
Print all the classifications of the triangle presented in the input.

**Input Samples**
```
7.0 5.0 7.0
```
```   
6.0 6.0 10.0
```
```  
6.0 6.0 6.0 
```
```  
5.0 7.0 2.0
```
```   
6.0 8.0 10.0  
```

**Output Samples**
```
TRIANGULO ACUTANGULO
TRIANGULO ISOSCELES
```
``` 
TRIANGULO OBTUSANGULO
TRIANGULO ISOSCELES 
```
```
TRIANGULO ACUTANGULO
TRIANGULO EQUILATERO
```
```
NAO FORMA TRIANGULO 
```
```
TRIANGULO RETANGULO
```