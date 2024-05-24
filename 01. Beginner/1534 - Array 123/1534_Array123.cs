using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n;
        string input;

        while ((input = Console.ReadLine()) != "EOF" && int.TryParse(input, out n))
        {
            int[,] matrix = new int[n, n];

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (r + c == n - 1)
                    {
                        matrix[r,c] = 2;
                        Console.Write(matrix[r,c]);  
                    }
                    else if (r == c)
                    {
                        matrix[r,c] = 1;
                        Console.Write(matrix[r,c]);
                    }
                    else
                    {
                        matrix[r,c] = 3;
                        Console.Write(matrix[r,c]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}