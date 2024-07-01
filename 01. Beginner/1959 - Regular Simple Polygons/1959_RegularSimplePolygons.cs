using System;

class URI
{
    static void Main(string[] args) 
    {
        long n, l, p;
        string[] input;
        
        input = Console.ReadLine().Split(' ');
        n = int.Parse(input[0]);
        l = int.Parse(input[1]);
        
        p = n * l;

        Console.WriteLine(p);
    }
}