using System;

class URI 
{
    static void Main(string[] args) 
    {
        double s = 0;
        double n = 1;
        double d = 1;

        while (n <= 39)
        {
            s += n / d;
            n += 2;
            d *= 2;
        }
        
        Console.WriteLine(s.ToString("F2"));
    }
}