using System;

class URI 
{
    static void Main(string[] args) 
    {
        int t = int.Parse(Console.ReadLine());

        while (t <= 2 || t >= 50)
            t = int.Parse(Console.ReadLine());

        int[] n = new int[1000];
        int x = 0;

        for (int i = 0; i < 1000; i++)
        {
            n[i] = x;
            x++;

            if (x == t)
                x = 0;

            Console.WriteLine($"N[{i}] = {n[i]}");
        }
    }
}