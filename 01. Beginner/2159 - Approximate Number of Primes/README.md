# 2159 - Approximate Number of Primes

Schoenfeld and Rosser published a paper in 1962 describing a minimum and a maximum value to the quantity of prime numbers up to **n**, for **n** ≥ 17. This quantity is represented by the function **(n)** and the inequality is shown below.

![2159_ApproximateNumberOfPrimes.webp](https://github.com/ricrochads/beecrowd-solutions/blob/main/01.%20Beginner/2159%20-%20Approximate%20Number%20of%20Primes/2159_ApproximateNumberOfPrimes.webp)

Your task is, given a natural number **n**, to compute the interval's minimum and maximum values to the approximate number of primes up to **n**.

**Input**<br>
The input is a natural number **n** (17 ≤ **n** ≤ 10^9).

**Output**<br>
The output is given as two values **P** and **M** with 1 decimal place each, such that **P** < **(n)** < **M** according to the given inequality above. These two values have one blank space between them.

**Input Samples**
````
17
````
````
50
````
````
100
````          

**Output Samples**
````
6.0 7.5
````
````
12.8 16.0
````
````
21.7 27.3
````     