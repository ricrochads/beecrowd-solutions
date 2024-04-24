using System;
using System.Linq;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        int[] portions = new int[5];

        Dictionary<string, int> guests = new Dictionary<string, int>()
        {
            { "Curupira", 300 },
            { "Boitatá", 1500 },
            { "Boto", 600 },
            { "Mapinguari", 1000 },
            { "Iara", 150 }
        };
        
        int totalGrams = 225;
        
        for (int i = 0; i < 5; i++)
        {
            portions[i] = int.Parse(Console.ReadLine());
            totalGrams += portions[i] * guests.ElementAt(i).Value;
        }

        Console.WriteLine(totalGrams);
    }
}