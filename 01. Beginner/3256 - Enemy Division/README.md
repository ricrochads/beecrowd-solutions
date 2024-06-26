# 3256 - Enemy Division

Captain Keram has to make a difficult decision. It is year 2147 and there is a big war in the world. His soldiers have been together since the war started, two years ago, and some of them have become enemies. Luckily, each soldier has at most 3 enemies.

They need to attack another country soon, and Keram is worried that soldiers who are enemies might not cooperate well during the battle. He has decided to divide them into groups such that every soldier has at most one enemy in his group. He also wants to make it simple, so he wants to use as few groups as possible. Can you divide the soldiers into groups for him?

**Input**<br>
On the first line there are two integers **n** and **m**, 2 ≤ **n** ≤ 100 000,0 ≤ **m** ≤ 3**n**/2, where **n** is the number of soldiers and **m** is the number of enemy pairs. Then follow **m** lines, each containing two space separated integers **a<sub>i</sub>**, **b<sub>i</sub>**, denoting that soldiers **a<sub>i</sub>** and **b<sub>i</sub>** are enemies, where 1 ≤ **a<sub>i</sub>** < **b<sub>i</sub>** ≤ **n**. You can assume that all soldiers have at most 3 enemies.

**Output**<br>
The first line of output contains the minimal number of groups of soldiers **k**. Each of the next **k** lines contains a space separated list of a soldiers in a unique group.

**Input Sample**
````
4 4 
1 2 
2 3 
3 4 
1 4
````

**Output Sample**
````
2 
1 3 
2 4
````