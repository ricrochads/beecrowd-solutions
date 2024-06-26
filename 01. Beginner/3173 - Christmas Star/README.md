# 3173 - Christmas Star

Jupiter and Saturn are the largest planets in the Solar System. They will be aligned in December (2020), between the 16th and the 21st. This conjunction is a rare phenomenon known as 'Christmas Satar' and can be seen from various locations on Earth. Based on the orbital period (in Earth years - A<sub>T</sub>) of Jupiter and Saturn, your code should inform the end date of the next revolutions taking as a starting point December 21, 2020 and the number of days elapsed. Consider that Jupiter takes 11.9 A<sub>T</sub> to complete its orbit around the Sun and that Saturn takes 29.6 A<sub>T</sub>. Use integer values to define the number of days that have elapsed and remember to include the days of leap years.

**Input**<br>
The entry will be an integer value **N** (0 < **N** <= 50) equivalent to the ordinal number of revolutions as of December 21, 2020. For example, **N** = 5 corresponds to the end date of the fifth revolution on each of the two planets.

**Output**
The output should show the number of days and (approximate) dates of the end of the revolution on the planets Jupiter and Saturn, respectively. Consider the following date format: yyyy - mm - dd

**Input Samples**
````
1
````
````
3
````
````
5
````

**Output Samples**
````
Dias terrestres para Jupiter = 4346
Data terrestre para Jupiter: 2032-11-14
Dias terrestres para Saturno = 10811 
Data terrestre para Saturno: 2050-07-28
````
````
Dias terrestres para Jupiter = 13039
Data terrestre para Jupiter: 2056-09-02
Dias terrestres para Saturno = 32434
Data terrestre para Saturno: 2109-10-10
````
````
Dias terrestres para Jupiter = 21732 
Data terrestre para Jupiter: 2080-06-21
Dias terrestres para Saturno = 54057
Data terrestre para Saturno: 2168-12-22
````