# 1118 - Several Scores with Validation

Write an program to read two scores of a student. Calculate and print the semester average. The program must accept only valid scores (a score must fit in the range [0.10]). Each score must be validated separately.

The program must print a message "novo calculo (1-sim 2-nao)" that means "new calculate (1-yes 2-no)". After, the input will be (1 or 2). 1 means a new calculation, 2 means that the execution must be finished.

**Input**<br>
The input file contains several positive or negative floating-point (double) values​. After the input of 2 valid scores, an integer number **X** will be read. Your program must stop when **X** = 2.

**Output**<br>
If an invalid score is read, must be printed the message "nota invalida". When two valid scores are read, the message "media = " must be printed folowed by the average between these 2 scores. The message "novo calculo (1-sim 2-nao)" must be printed after reading X. This message should be displayed again if the standard input number for X is less than 1 or greater than 2, as example below.

The output average must be printed with 2 digits after the decimal point.

| Input Sample                                                             | Output Sample                                                                                                                                                        |
|:-------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| -3.5 <br> 3.5 <br> 11.0 <br> 10.0 <br> 4 <br> 1 <br> 8.0 <br> 9.0 <br> 2 | nota invalida <br> nota invalida <br> media = 6.75 <br> novo calculo (1-sim 2-nao) <br> novo calculo (1-sim 2-nao) <br> media = 8.50 <br> novo calculo (1-sim 2-nao) |