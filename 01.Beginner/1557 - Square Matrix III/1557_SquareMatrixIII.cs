using System;
using System.Linq;

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
                    matrix[r, c] = (int)Math.Pow(2, r + c);
            }

            int t = matrix[n - 1, n - 1].ToString().Length;

            foreach (int r in Enumerable.Range(0, n))
            {
                foreach (int c in Enumerable.Range(0, n))
                {
                    Console.Write(matrix[r, c].ToString().PadLeft(t));
                    Console.Write(c == n - 1 ? "" : " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}