# 2708 - Tourists in the Huacachina Park

The municipal tourism agency of the city of Ica in Peru has set up a checkpoint for adventure jeeps that ascend to the dunes of Hucachina Park. As during the day, there are several off-roads that go up and down the national park, and tourists do not always use the same transportation for the round trip, the city hall needed to have better control and security over the flow of visitors in the park. Develop a program that receives as input if a jeep is entering or returning from the park and the amount of tourists this vehicle is transporting. At the end of the shift, the program must indicate how many vehicles and tourists are still missing from the adventure.

**Input**<br>
The program must receive successive input pairs. Each pair should indicate the jeep's movement and the amount of tourists it is carrying. The first entry should be "*SALIDA*" or "*VUELTA*". "*SALIDA*" should indicate that the jeep is leaving the center and entering the park; and "*VUELTA*" that the Jeep is returning from the ride. Immediately following, the program receives an integer **T** (where, 0 <= **T** <= 20) indicating the amount of tourists being transported by the jeep. The string "*ABEND*" should be the end-of-processing indicator.

**Output**<br>
As a goal the program must present two exits, one in each line: the amount of tourists and the amount of jeeps that still need to return from the park.

| Input Samples	                                                                                | Output Samples |
|:----------------------------------------------------------------------------------------------|:---------------|
| SALIDA 10 <br> SALIDA 12 <br> SALIDA 10 <br> VUELTA 20 <br> ABEND                             | 12 <br> 2      |
| SALIDA 15 <br> SALIDA 20 <br> VUELTA 15 <br> VUELTA 15 <br> SALIDA 0 <br> VUELTA 0 <br> ABEND | 5  <br> 0      |