# 2310 - Volleyball

A volleyball coach would like to keep statistics about his team. In every game he keeps track of the number of services, blocks and attacks of each player, as well as how many of these services, blocks and attacks were successful (scored points). Your program must show, with two decimal points what is the total percentage of services, blocks and attacks by the whole team that were successful.

**Input**<br>
Input starts with the number of players **N** (1 ≤ **N** ≤ 100), followed by the names of each of these players. Below the name of each player, two rows of integers are presented. In the first row, the numbers represent the service, blocks and attack attempts (0 ≤ **S**, **B**, **A** ≤ 10000) by the specific player. In the second row there is the number of these services, blocks and attacks (0 ≤ **S1** ≤ **S**; 0 ≤ **B1** ≤ **B**; 0 ≤ **A1** ≤ **A**) that were successful.

**Output**<br>
The output must contain the total percentage of successful services, blocks and attacks by the whole team, with two digits after the decimal point, as shown in the example.

**Input Sample**
````
3
Renan
10 20 12
1 10 9
Jonas
8 7 1
2 7 0
Edson
3 3 3
1 2 3
````

**Output Sample**
````
Pontos de Saque: 19.05 %.
Pontos de Bloqueio: 63.33 %.
Pontos de Ataque: 75.00 %.
````