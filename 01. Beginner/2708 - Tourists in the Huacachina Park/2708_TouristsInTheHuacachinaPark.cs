using System;

class URI 
{
    static void Main(string[] args) 
    {
        string input;
        int amountOfTourists = 0;
        int jeepsToReturnCount = 0;
        
        while ((input = Console.ReadLine().ToUpper()) != "ABEND")
        {
            string[] inputPairs = input.Split(' ');
            string jeepsMovement = inputPairs[0];
            int tourists = int.Parse(inputPairs[1]);

            if (jeepsMovement == "SALIDA")
            {
                amountOfTourists += tourists;
                jeepsToReturnCount++;
            }
            else if (jeepsMovement == "VUELTA")
            {
                amountOfTourists -= tourists;
                jeepsToReturnCount--;
            }
        } 
        
        Console.WriteLine(amountOfTourists);
        Console.WriteLine(jeepsToReturnCount);
    }
}