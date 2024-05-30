using System;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        
        int[] x = new int[m];

        for (int i = 0; i < m; i++)
            x[i] = int.Parse(Console.ReadLine());

        HashSet<int> stickers = new HashSet<int>();

        foreach (int sticker in x)
            stickers.Add(sticker);

        Console.WriteLine(n - stickers.Count);
    }
}