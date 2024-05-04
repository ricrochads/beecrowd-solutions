# 1048 - Salary Increase

The company ABC decided to give a salary increase to its employees, according to the following table:

| Salary                                                                                            | Readjustment Rate                     |
|:-------------------------------------------------------------------------------------------------:|:-------------------------------------:|
| 0 - 400.00 <br> 400.01 - 800.00 <br> 800.01 - 1200.00 <br> 1200.01 - 2000.00 <br> Above 2000.00   | 15% <br> 12% <br> 10% <br> 7% <br> 4% |

Read the employee's salary, calculate and print the new employee's salary, as well the money earned and the increase percentual obtained by the employee, with corresponding messages in Portuguese, as the below example.

**Input**<br>
The input contains only a floating-point number, with 2 digits after the decimal point.

**Output**<br>
Print 3 messages followed by the corresponding numbers (see example) informing the new salary, the among of money earned (both must be shown with 2 decimal places) and the percentual obtained by the employee. Note:<br>
*Novo salario:*  means *"New Salary"*<br>
*Reajuste ganho:* means *"Money earned"*<br>
*Em percentual:* means *"In percentage"*<br>

**Input Samples**
```
400.00
```
```
800.01
```
```      
2000.00     
```

**Output Samples**
```
Novo salario: 460.00  
Reajuste ganho: 60.00  
Em percentual: 15 %
```
```
Novo salario: 880.01  
Reajuste ganho: 80.00  
Em percentual: 10 %
```
```
Novo salario: 2140.00 
Reajuste ganho: 140.00
Em percentual: 7 % 
```