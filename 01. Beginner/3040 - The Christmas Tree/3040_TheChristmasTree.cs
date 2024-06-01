using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        int n;

        do
            n = int.Parse(Console.ReadLine());
        while (n < 0 || n > 10000);

        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine().Split(default(string[]), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var (h, d, g) = (input[0], input[1], input[2]);

            if (h >= 200 && h <= 300 && d >= 50 && g >= 150)
                Console.WriteLine("Sim");
            else
                Console.WriteLine("Nao");
        }
    }
}