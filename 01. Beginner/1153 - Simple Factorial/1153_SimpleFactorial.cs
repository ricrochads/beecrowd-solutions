using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n;

        do
            n = int.Parse(Console.ReadLine());
        while (n < 0 || n > 13);

        int factorial = n;

        for (int i = 1; i < n; i++)
            factorial *= n - i; 

        Console.WriteLine(factorial);
    }
}