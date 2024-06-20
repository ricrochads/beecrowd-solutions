using System;

class URI
{
    static void Main(string[] args) 
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal[] n = new decimal[100];
        
        n[0] = x;

        for (int index = 1; index < 100; index++)
            n[index] = n[index - 1] / 2;
        
        int i = 0;

        Array.ForEach(n, y => {
            Console.WriteLine($"N[{i}] = {decimal.Round((decimal)y, 4, MidpointRounding.ToEven)}");
            i++;
        });
    }
}