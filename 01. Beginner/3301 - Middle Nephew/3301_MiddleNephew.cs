using System;
using System.Linq;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        int[] ages = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int h = ages[0], z = ages[1], l = ages[2];
        
        Dictionary<int, string> nephews = new Dictionary<int, string>()
        {
            { h, "huguinho" },
            { z, "zezinho" },
            { l, "luisinho" },
        };

        Console.WriteLine(nephews[ages.First(x => x != ages.Min() && x != ages.Max())]);    
    }
}