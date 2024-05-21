# 3480 - Adjacent Chairs

Find the adjacent and available seats in each row of the classroom. The first column of the result must contain the row identifier, the second column the number of the chair on the left and the third the number of the chair on the right. The result must be ordered by the value of the second column of the result (left).

![3480_adjacent_chairs.webp](https://github.com/ricrochads/beecrowd-solutions/blob/main/09.%20SQL/3480%20-%20Adjacent%20Chairs/3480_adjacent_chairs.webp)

**Scheme**

| chairs |
|:------:|

| Column	| Type    |
|:----------|:--------|
| id	    | numeric |
| queue	    | numeric |
| available	| boolean |

**Tables**

| chairs |
|:------:|

| id    | queue	| available |
|:------|:------|:----------|
| 1	    | 1	    | FALSE     |
| 2	    | 1	    | FALSE     |
| 3	    | 1	    | TRUE      |
| 4	    | 1	    | FALSE     |
| 5	    | 1	    | FALSE     |
| 6	    | 1	    | FALSE     |
| 7	    | 1	    | TRUE      |
| 8	    | 1	    | TRUE      |
| 9	    | 2	    | TRUE      |
| 10    | 2     | FALSE     |
| 11    | 2     | TRUE      |
| 12    | 2     | TRUE      |
| 13    | 2     | FALSE     |
| 14    | 2     | TRUE      |
| 15    | 2     | TRUE      |
| 16    | 2     | FALSE     |
| 17    | 3     | TRUE      |
| 18    | 3     | FALSE     |
| 19    | 3     | TRUE      |
| 20    | 3     | FALSE     |
| 21    | 3     | TRUE      |
| 22    | 3     | TRUE      |
| 23    | 3     | FALSE     |
| 24    | 3     | FALSE     |
| 25    | 4     | TRUE      |
| 26    | 4     | FALSE     |
| 27    | 4     | FALSE     |
| 28    | 4     | TRUE      |
| 29    | 4     | TRUE      |
| 30    | 4     | FALSE     |
| 31    | 4     | FALSE     |
| 32    | 4     | TRUE      |

**Output Sample**

| queue	| left	| right |
|:------|:------|:------|
| 1	    | 7	    | 8     |
| 2	    | 11    | 12    |
| 2	    | 14    | 15    |
| 3	    | 21    | 22    |
| 4	    | 28    | 29    |