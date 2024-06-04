using System;

class URI 
{
    static void Main(string[] args) 
    {
        double s = 1;

        for (double i = 2; i <= 100; i++)
            s += 1/i;
        
        Console.WriteLine(s.ToString("F2"));
    }
}