using System;

class URI 
{
    static void Main(string[] args) 
    {
        int c = int.Parse(Console.ReadLine());
        int count = 0;

        while (count < c)
        {
            int s = 0;
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    s += 1;
                else
                    s -= 1;
            }
            Console.WriteLine(s);
            count++;
        }
    }
}