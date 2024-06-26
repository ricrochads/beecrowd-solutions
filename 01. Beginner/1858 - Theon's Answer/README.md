# 1858 - Theon's Answer

Ramsay: *"(...) you win the game if you figure out who I am and why I'm torturing you."*

Theon must think quickly and guess who his torturer is! However, Ramsey already decided what he will do after Theon gives his answer.

There are **N** people Theon may say the torturer is. Let us consider that the people are numbered from 1 to **N**. If Theon answers the torturer is person **i**, Ramsay will hit him T<sub>i</sub> times.

You task is to help Theon and determine what he should answer in order to minimize the number of times he will be hit.

**Input**<br>
The first line contains an integer **N** (1 ≤ **N** ≤ 100). The second line contains **N** integers T<sub>1</sub>, T<sub>2</sub>, ..., T<sub>N</sub> (0 ≤ T<sub>i</sub> ≤ 20).

**Output**<br>
Print a single line containing the number of the person Theon must say the torturer is. If there is more than one possible answer, print the smallest one.

**Input Samples**
````
3
8 0 7
````
````
2
1 1
````

**Output Samples**
````
2
````
````
1
````