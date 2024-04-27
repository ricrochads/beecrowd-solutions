# 3204 - Honeycomb Walk

A bee larva living in a hexagonal cell of a large honeycomb decides to creep for a walk. In each “step” the larva may move into any of the six adjacent cells and after **N** steps, it is to end up in its original cell.

Your program has to compute, for a given **N**, the number of different such larva walks.

**Input**<br>
The first line contains an integer giving the number of test cases to follow. Each case consists of one line containing an integer **N**, where 1 ≤ **N** ≤ 14.

**Output**<br>
For each test case, output one line containing the number of walks. Under the assumption 1 ≤ **N** ≤ 14, the answer will be less than 2³¹

| Input Sample    | Output Sample |
|:----------------|:--------------|
| 2 <br> 2 <br> 4 | 6 <br> 90     |