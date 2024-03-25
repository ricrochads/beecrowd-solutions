using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());

        for (int multiplier = 1; multiplier <= 10; multiplier++)
        {
            int product = multiplier * n;
            Console.WriteLine($"{multiplier} x {n} = {product}");
        }
    }
}