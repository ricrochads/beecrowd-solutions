#  1040 - Average 3

Read four numbers (N1, N2, N3, N4), which one with 1 digit after the decimal point, corresponding to 4 scores obtained by a student. Calculate the average with weights 2, 3, 4 e 1 respectively, for these 4 scores and print the message *"Media: "* (Average), followed by the calculated result. If the average was 7.0 or more, print the message *"Aluno aprovado."* (Approved Student). If the average was less than 5.0, print the message: *"Aluno reprovado."* (Reproved Student). If the average was between 5.0 and 6.9, including these, the program must print the message "Aluno em exame." (In exam student).

In case of exam, read one more score. Print the message *"Nota do exame: "* (Exam score) followed by the typed score. Recalculate the average (sum the exam score with the previous calculated average and divide by 2) and print the message *“Aluno aprovado.”* (Approved student) in case of average 5.0 or more) or *"Aluno reprovado."* (Reproved student) in case of average 4.9 or less. For these 2 cases (approved or reproved after the exam) print the message *"Media final: "* (Final average) followed by the final average for this student in the last line.

**Input**<br>
The input contains four floating point numbers that represent the students' grades.

**Output**<br>
Print all the answers with one digit after the decimal point.

**Input Samples**              
```
2.0 4.0 7.5 8.0
6.4  
```
```
2.0 6.5 4.0 9.0
```
```      
9.0 4.0 8.5 9.0 
```        

**Output Samples**
```
Media: 5.4
Aluno em exame.
Nota do exame: 6.4 
Aluno aprovado.
Media final: 5.9
```
```
Media: 4.8 
Aluno reprovado.
```
```                                                                
Media: 7.3
Aluno aprovado.
```                                                                 