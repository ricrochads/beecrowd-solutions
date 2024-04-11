using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n;
        double p, m;

        do
            n = int.Parse(Console.ReadLine());
        while (n < 17 || n > Math.Pow(10, 9));

        p = n / Math.Log(n);
        m = 1.25506 * n / Math.Log(n);

        Console.WriteLine($"{p:F1} {m:F1}"); 
    }
}