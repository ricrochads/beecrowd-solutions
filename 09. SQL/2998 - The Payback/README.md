# 2998 - The Payback

An investment company desire to calculate the client's payback by finding out what month the project's operations are equal to or higher than the initial investment. For example, client Lucas invested 1000$ and only in the third month he got his payback since the sum of all his operations was superior to his investment. On the other hand, client Daniel didn't reach his payback, since his investment was 500$ and the sum of all his operations was 230$. You need to show the client name, his initial investment, the payback month and the payback value (accumulated value - initial investment value). Furthermore, you must show the result order by the highest to lowest payback.

**Schema**

| clients |
|:-------:|

| Column	    | Type         |
|:--------------|:-------------|
| id (PK)	    | integer      |
| name	        | varchar (50) |
| investment	| numeric      |

| operations |
|:----------:|

| Column	        | Type    |
|:------------------|:--------|
| id (PK)	        | integer |
| client_id (FK)	| integer |
| month	            | integer |
| profit	        | numeric |

**Tables**

| clients |
|:-------:|

| id | name	    | investment |
|:---|:---------|:-----------|
| 1	 | Daniel	| 500        |
| 2	 | Oliveira	| 2000       |
| 3	 | Lucas	| 1000       |

| operations |
|:----------:|

| id | client_id | month | profit |
|:---|:----------|:------|:-------|
| 1	 | 1	     | 1	 | 230    |
| 2	 | 2	     | 1	 | 1000   |
| 3	 | 2	     | 2	 | 1000   |
| 4	 | 3	     | 1	 | 100    |
| 5	 | 3	     | 2	 | 300    |
| 6	 | 3	     | 3	 | 900    |
| 7	 | 3	     | 4	 | 400    |

**Output Sample**

| name	    | investment	| month_of_payback	| return |
|:----------|:--------------|:------------------|:-------|
| Lucas	    | 1000	        | 3	                | 300    |
| Oliveira	| 2000	        | 2	                | 0      |