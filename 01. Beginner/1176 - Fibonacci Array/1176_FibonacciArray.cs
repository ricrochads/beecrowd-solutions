using System;

class URI
{
    static void Main(string[] args) 
    {
        int t = int.Parse(Console.ReadLine());

        long[] fib = new long[61];
        fib[0] = 0;
        fib[1] = 1;
        fib[2] = 1;

        for (int i = 3; i <= 60; i++)
            fib[i] = fib[i - 1] + fib[i - 2];

        int[] n = new int[t];

        for (int i = 0; i < t; i++)
            n[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string x = Convert.ToString(fib.GetValue(n[i]));
            Console.WriteLine($"Fib({n[i]}) = {x}");
        }
    }
}