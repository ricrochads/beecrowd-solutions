# 1047 - Game Time with Minutes

Read the start time and end time of a game, in hours and minutes (initial hour, initial minute, final hour, final minute). Then print the duration of the game, knowing that the game can begin in a day and finish in another day,

*Obs.:* With a maximum game time of 24 hours and the minimum game time of 1 minute.

**Input**<br>
Four integer numbers representing the start and end time of the game.

**Output**<br>
Print the duration of the game in hours and minutes, in this format: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” . Which means: the game lasted XXX hour(s) and YYY minutes.

**Input Samples**
```
7 8 9 10
```
```
7 7 7 7
```
```
7 10 8 9
```

**Output Samples**
```
O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)
```
```
O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)
```
```
O JOGO DUROU 0 HORA(S) E 59 MINUTO(S)
```