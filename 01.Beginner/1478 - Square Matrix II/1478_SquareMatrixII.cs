using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int n;

        while ((n = int.Parse(Console.ReadLine())) != 0)
        {
            int[,] matrix = new int[n, n];
            
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                    matrix[r, c] = Math.Abs(r - c) + 1;
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0,3}", matrix[r, c]);

                    if (c < n - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}