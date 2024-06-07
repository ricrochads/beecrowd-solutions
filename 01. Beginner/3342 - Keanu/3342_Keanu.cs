using System;

class URI 
{
    static void Main(string[] args) 
    {
        double n;
        int a = 0;
        int b = 0;

        do
            n = double.Parse(Console.ReadLine()); 
        while (n < 2 && n > 100);

        n = Math.Pow(n, 2);

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
                a++;
            else
                b++;
        }

        Console.WriteLine($"{a} casas brancas e {b} casas pretas");
    }
}