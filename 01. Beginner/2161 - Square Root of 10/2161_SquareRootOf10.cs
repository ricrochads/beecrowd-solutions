using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n;
        double sqrtValue = 0;

        do
            n = int.Parse(Console.ReadLine());
        while (n < 0 || n > 100);

        for (int i = 0; i < n; i++)
           sqrtValue = 1 / (6 + sqrtValue);
        
        sqrtValue += 3;

        Console.WriteLine($"{sqrtValue:F10}");
    }
}