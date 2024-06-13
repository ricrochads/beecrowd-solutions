# 3037 - Playing Darts by Distance

John and Mary created their own version of darts, darts by distance. Each one throws 3 darts, choosing how far they will play from the target. In the normal game of darts, a number x is scored by the distance between where the dart hit and the center of the target. In the game of John and Mary it is punctuated xd where d is the distance betwen the shooter and the target.

John asks you to make an algorithm that gives the score given the distance of each turn, returns the winner

**Input**<br>
The first line of the entry consists of a **N** number of test cases. In each test case there will be 6 lines, where the first 3 lines correspond to the pitches of John and the next 3 lines to the pitches of Mary. Each line of a test case consists of two numbers **X** and **D** where **X** is the score and **D** is the distance

**Output**<br>
The output consists of the winner of each test case.

**Input Sample**
```
2
1 10
2 1
1 1
10 10
1 0
2 0
10 1
1 10
2 5
1 1
2 1
3 0
```

**Output Sample**
```
MARIA
JOAO
```