# 2702 - Hard Choice

In long flights, airlines offer hot meals. Usually the flight attendants push carts containing the meals down along the aisles of the plane. When a cart reaches your row, you are asked right away: “Chicken, beef, or pasta?” You know your choices, but you have only a few seconds to choose and you don’t know how your choice will look like because your neighbor hasn’t opened his wrap yet...

The flight attendant in this flight decided to change the procedure. First she will ask all passengers what choice of meal they would prefer, and then she will check if the number of meals available in this flight for each choice are enough.

As an example, consider that the available number of meals for chicken, beef and pasta are respectively (80, 20, 40), while the number of passenger’s choices for chicken, beef and pasta are respectively (45, 23, 48). In this case, eleven people will surely not receive their selection for a meal, since three passengers who wanted beef and eight passengers who wanted pasta cannot be pleased.

Given the quantity of meals available for each choice and the number of meals requested for each choice, could you please help the flight attendant to determine how many passengers will surely not receive their selection for a meal?

**Input**<br>
The first line contains three integers **Ca**, **Ba** and **Pa** (0 ≤ **Ca**, **Ba**, **Pa** ≤ 100), representing respectively the number of meals available for chicken, beef and pasta. The second line contains three integers **Cr**, **Br** and **Pr** (0 ≤ **Cr**, **Br**, **Pr** ≤ 100), indicating respectively the number of meals requested for chicken, beef and pasta.

**Output**<br>
Output a single line with an integer representing the number of passengers that will surely not receive their selection for a meal.

**Input Samples**
````
80 20 40 
45 23 48
````
````
0 0 0 
100 100 100
````
````
41 42 43 
41 42 43
````

**Output Samples**
````
11
````
````          
300
````
````          
0
````          