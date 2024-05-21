# 3481 - Classifying a Tree

Given the following balanced binary tree stored in the nodes table, classify each node with types LEAF, INNER, and ROOT. Present the result ordered by the value of the node identifier.

![3481_classifying_a_tree.webp]()

**Scheme**

| nodes |
|:-----:|

| Column	| Type    |
|:----------|:--------|
| node_id	| numeric |
| pointer	| numeric |

**Tables**

| nodes |
|:-----:|

| node_id	| pointer   |
|:----------|:----------|
| 50	    | 30        |
| 50	    | 75        |
| 30	    | 15        |
| 30	    | 35        |
| 15	    | 1         |
| 15	    | 20        |
| 35	    | 32        |
| 35	    | 40        |
| 1	        | null      |
| 20	    | null      |
| 32	    | null      |
| 40	    | null      |
| 75	    | 60        |
| 75	    | 90        |
| 60	    | 55        |
| 60	    | 70        |
| 90	    | 80        |
| 90	    | 95        |
| 55	    | null      |
| 70	    | null      |
| 80	    | null      |
| 95	    | null      |

**Output Sample**

| node_id	| type  |
|:----------|:------|
| 1	        | LEAF  |
| 15	    | INNER |
| 20	    | LEAF  |
| 30	    | INNER |
| 32	    | LEAF  |
| 35	    | INNER |
| 40	    | LEAF  |
| 50	    | ROOT  |
| 55	    | LEAF  |
| 60	    | INNER |
| 70	    | LEAF  |
| 75	    | INNER |
| 80	    | LEAF  |
| 90	    | INNER |
| 95	    | LEAF  |