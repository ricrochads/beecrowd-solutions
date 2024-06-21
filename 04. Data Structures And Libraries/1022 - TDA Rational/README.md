# 1022 - TDA Rational

You were invited to do a little job for your Mathematic teacher. The job is to read a Mathematic expression in format of two rational numbers (numerator / denominator) and present the result of the operation. Each operand or operator is separated by a blank space. The input sequence (each line) must respect the following format: number, (‘/’ char), number, operation char (‘/’, ‘*’, ‘+’, ‘-‘), number, (‘/’ char), number. The answer must be presented followed by ‘=’ operator and the simplified answer. If the answer can’t be simplified, it must be repeated after a ‘=’ operator.

Considering N1 and D1 as numerator and denominator of the first fraction, follow the orientation about how to do each one of these 4 operations:

- Sum: (N1 * D2 + N2 * D1) / (D1 * D2)
- Subtraction: (N1 * D2 - N2 * D1) / (D1 * D2)
- Multiplication: (N1 * N2) / (D1 * D2)
- Division: (N1 / D1) / (N2 / D2), that means (N 1* D2) / (N2 * D1)

**Input**<br>
The input contains several cases of test. The first value is an integer **N** (1 ≤ **N** ≤ 1 * 10<sup>4</sup>), indicating the amount of cases of test that must be read. Each case of test contains a rational value **X** (1 ≤ **X** ≤ 1000), an operation (-, +, * or /) and another rational value **Y** (1 ≤ **Y** ≤ 1000).

**Output**<br>
The output must be a rational number, followed by a “=“ sign and another rational number, that is the simplification of the first value. In case of the first value can’t be simplified, the same value must be repeated after the ‘=’ sign.

**Input Sample**
````
4
1 / 2 + 3 / 4
1 / 2 - 3 / 4
2 / 3 * 6 / 6
1 / 2 / 3 / 4
````

**Output Sample**
````
10/8 = 5/4
-2/8 = -1/4
12/18 = 2/3
4/6 = 2/3
````