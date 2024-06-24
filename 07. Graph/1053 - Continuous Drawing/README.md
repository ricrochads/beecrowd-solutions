# 1053 - Continuous Drawing

A simple task! You will be given the end points of some line segments. Just draw them. Too easy, right?

You decide to challenge yourself and thus plan to add some constraints.

1) Start from the end point of any line segment.
2) Do not lift your pen off the paper.
3) You can go over a line more than once.
4) Do not draw any line other than the ones mentioned.
5) You can only change direction at integer coordinates of x & y.
6) Use the least amount of ink needed.

You need 1 unit of ink to draw one unit of line. Distances between successive points are 1 unit.

So Distance (A1 to B1) = 1 unit and Distance (A1 to A2) = 1 unit.

![1053_ContinuousDrawing.jpg](https://github.com/ricrochads/beecrowd-solutions/blob/main/07.%20Graph/1053%20-%20Continuous%20Drawing/1053_ContinuousDrawing.jpg)

**Input**<br>
The first line of input is an integer **T** (**T** < 20) that indicates the total number of test cases. Each case starts with an integer **N** (**N** < 10). Then **N** lines follow, each describing a line segment. A line segment is defined by two points **Y**<sub>**1**</sub> **X**<sub>**1**</sub> **Y**<sub>**2**</sub> **X**<sub>**2**</sub>. **Y**<sub>**1**</sub> and **Y**<sub>**2**</sub> will be from **[A,E]**. **X**<sub>**1**</sub> and **X**<sub>**2**</sub> will be from **[1,5]**. The first sample is taken from the figure above. So look at the sample for exact format.

**Output**<br>
For each case, output the case number followed by the total amount of ink requried with 2 digits after the decimal point. If the lines can’t be drawn without lifting the pen then print ~x( instead.

**Input Sample**
````
2
4
A1 C2
B3 C3
C4 C2
C2 D2
2
A1 A5
E1 E5
````

**Output Sample**
````
Case 1: 8.24
Case 2: ~x(
````