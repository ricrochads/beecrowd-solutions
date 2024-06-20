using System;

class URI
{
    static void Main(string[] args) 
    {
        int n, x;

        do
            n = int.Parse(Console.ReadLine());
        while (n < 1 || n > 100);

        for (int i = 0; i < n;)
        {
            x = int.Parse(Console.ReadLine());

            if (!IsValidNumber(x))
                continue;

            if (IsPrimeNumber(x))
                Console.WriteLine($"{x} eh primo");
            else
                Console.WriteLine($"{x} nao eh primo");
            
            i++;
        }
    }

    static bool IsValidNumber(int x)
    {
        return x > 1 && x <= 10000000;
    }

    static bool IsPrimeNumber(int x)
    {
        int count = 0;

        for (int i = 1; i <= x; i++)
        {
            if (x % i == 0)
                count++;
        }    

        return count == 2;
    }
}