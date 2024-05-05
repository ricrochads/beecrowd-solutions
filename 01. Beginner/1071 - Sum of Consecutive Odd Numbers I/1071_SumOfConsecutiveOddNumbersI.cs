using System;

class URI 
{
    static void Main(string[] args) 
    {
        int x, y, min, max, sum;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        min = (x < y) ? x : y;
        max = (x < y) ? y : x;

        sum = 0;

        for (int i = min + 1; i < max; i++)
        {
            if (i % 2 != 0)
                sum += i;
        }

        Console.WriteLine(sum);
    }
}