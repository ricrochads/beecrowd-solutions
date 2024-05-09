using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i} {Math.Pow(i, 2)} {i * Math.Pow(i, 2)}");
            Console.WriteLine($"{i} {Math.Pow(i, 2) + 1} {i * Math.Pow(i, 2) + 1}");
        }
    }
}