# 3161 - The Forgotten Fruits

Sheldon Cooper is an eccentric character in the Hollywood universe. He recently had an accident and ended up forgetting which fruits he likes to eat. However, the time has come to prepare breakfast and Sheldon does not want to go through the experience of tasting fruit and discovering that he does not like it. Then, bothered by this situation, Sheldon convinced his friend Leonard Hofstadter to help him. Leonard remembers the moment he met Sheldon and due to his friend's eccentricities, he kept on his computer a list with the name of the fruits that Sheldon likes to eat. Leonard, very excited by his wit, opens the file and notes that something is wrong: the contents of the file have been scrambled by a computer virus. Determined to resolve this issue, Leonard experimented and concluded that it is possible to read the contents of the file and find out whether Sheldon likes a particular fruit or not. From experiments, Leonard noted that the virus made some(s) of the following changes: 

1) Added new characters to the left and/or right to the name of the fruit that was on the list; 
2) Changed some letters, in this case, some became uppercase and others lowercase; 
3) The name of the fruit on the list has been inverted ("Bergamota" => "Atomagreb"). 

As Leonard studied programming, he will create a program that is named after a fruit and returns whether Sheldon likes that fruit or not.

**Input**<br>
The first line contains two integers: 

1) **N** that represents the number of fruit names that will be checked/searched, limited by [1,100]; 
2) **M** which represents the number of lines in the list of fruit names, limited by [15,500]; 

In addition, each **M** line of the name list and each **N** line with the fruit name follow the limit: [4,100].

**Output**<br>
For each fruit searched, show the output: *"Sheldon come a fruta X"* or *"Sheldon detesta a fruta X"* (where **X** is the name of the fruit that was verified in the list, in lowercase).

**Input Sample**
````
6 15 
Jenipapo 
Amora 
Mangaba 
Acerola 
Granadilla 
Abacate
````

**Output Sample**
````
Sheldon come a fruta jenipapo 
Sheldon come a fruta amora 
Sheldon come a fruta mangaba 
Sheldon detesta a fruta acerola 
Sheldon detesta a fruta granadilla 
Sheldon detesta a fruta abacate
````