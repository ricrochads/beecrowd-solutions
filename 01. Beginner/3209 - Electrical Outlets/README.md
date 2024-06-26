# 3209 - Electrical Outlets

Roy has just moved into a new apartment. Well, actually the apartment itself is not very new, even dating back to the days before people had electricity in their houses. Because of this, Roy’s apartment has only one single wall outlet, so Roy can only power one of his electrical appliances at a time.

Roy likes to watch TV as he works on his computer, and to listen to his HiFi system (on high volume) while he vacuums, so using just the single outlet is not an option. Actually, he wants to have all his appliances connected to a powered outlet, all the time. The answer, of course, is power strips, and Roy has some old ones that he used in his old apartment. However, that apartment had many more wall outlets, so he is not sure whether his power strips will provide him with enough outlets now.

Your task is to help Roy compute how many appliances he can provide with electricity, given a set of power strips. Note that without any power strips, Roy can power one single appliance through the wall outlet. Also, remember that a power strip has to be powered itself to be of any use.

**Input**<br>
Input vill start with a single integer 1 ≤ **N** ≤ 20, indicating the number of test cases to follow. Then follow **N** lines, each describing a test case. Each test case starts with an integer 1 ≤ **K** ≤ 10, indicating the number of power strips in the test case. Then follow, on the same line, **K** integers separated by single spaces, **O<sub>1</sub>** **O<sub>2</sub>** ... **O<sub>k</sub>**, where 2 ≤ **O<sub>i</sub>** ≤ 10, indicating the number of outlets in each power strip.

**Output**<br>
Output one line per test case, with the maximum number of appliances that can be powered.

**Input Sample**
````
3 
3 2 3 4 
10 4 4 4 4 4 4 4 4 4 4 
4 10 10 10 10
````

**Output Sample**
````
7 
31 
37
````