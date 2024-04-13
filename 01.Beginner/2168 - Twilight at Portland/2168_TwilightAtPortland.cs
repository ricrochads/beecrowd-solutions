using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        int n;
        
        do
            n = int.Parse(Console.ReadLine());
        while (n < 1 || n > 100);
        
        n += 1;
        int[,] cameras = new int[n, n];  

        for (int r = 0; r < n; r++)
        {
            int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int c = 0; c < n; c++)
                cameras[r, c] = line[c];
        }

        for (int r = 0; r < n - 1; r++)
        {
            for (int c = 0; c < n - 1; c++)
            {
                if ((cameras[r, c] + cameras[r + 1, c] + cameras[r, c + 1] + cameras[r + 1, c + 1]) < 2)
                    Console.Write('U');
                else
                    Console.Write('S');
            }
            Console.WriteLine();
        }
    }
}