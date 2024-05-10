using System;

class URI 
{
    static void Main(string[] args) 
    {
        int x = int.Parse(Console.ReadLine());
        
        int z;

        do
            z = int.Parse(Console.ReadLine());
        while (z <= x);
        
        int sum = x;
        int summedIntegers = 0;

        while (sum <= z)
        {
            sum += x + 1;
            summedIntegers += 1;
        }

        Console.WriteLine(summedIntegers);
    }
}