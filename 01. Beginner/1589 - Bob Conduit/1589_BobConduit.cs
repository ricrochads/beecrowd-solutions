using System;

class URI 
{
    static void Main(string[] args) 
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string[] r = Console.ReadLine().Split(' ');

            Array.Sort(r);

            int r1 = int.Parse(r[0]);
            int r2 = int.Parse(r[1]);

            Console.WriteLine(r1 + r2);
        }
    }
}