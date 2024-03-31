using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Ho");
               
            if (i < n)
                Console.Write(" ");
            else
                Console.WriteLine("!");
        }
    }
}