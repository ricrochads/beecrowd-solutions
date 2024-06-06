using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n;

        do
            n = int.Parse(Console.ReadLine());
        while (n <= 0 || n >= 46);

        int[] f = new int[n];
        f[0] = 0;
        f[1] = 1;

        for (int i = 2; i < n; i++)
            f[i] = f[i - 1] + f[i - 2];

        foreach (int i in f)
        {
            if (i > 0) Console.Write(" ");
            Console.Write(i);
        }

        Console.WriteLine();
    }
}