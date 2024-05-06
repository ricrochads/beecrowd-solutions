using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n, x;

        do
            n = int.Parse(Console.ReadLine());
        while (n < 0);

        for (int i = 0; i < n; i++)
        {
            x = int.Parse(Console.ReadLine());

            if (x == 0)
                Console.WriteLine("NULL");
            else
            {
                string parity = (x % 2 == 0) ? "EVEN" : "ODD";
                string sign = (x < 0) ? "NEGATIVE" : "POSITIVE";
                
                Console.WriteLine($"{parity} {sign}");
            }
        }
    }
}