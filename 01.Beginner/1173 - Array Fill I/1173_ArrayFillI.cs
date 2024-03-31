using System;

class URI 
{
    static void Main(string[] args) 
    {
        int v = int.Parse(Console.ReadLine());

        while(v >= 50)
            v = int.Parse(Console.ReadLine());

        int[] n = new int[10];

        for (int i = 0; i < 10; i++)
        {
            n[i] += v;
            Console.WriteLine($"N[{i}] = {n[i]}");
            v *= 2;
        }
    }
}