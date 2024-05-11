using System;

class URI 
{
    static void Main(string[] args) 
    {
        int x, y;

        do
        {
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
        } while (x < 0 || y < 0);

        for (int i = Math.Min(x, y) + 1; i < Math.Max(x, y); i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
                Console.WriteLine(i);
        }
    }
}