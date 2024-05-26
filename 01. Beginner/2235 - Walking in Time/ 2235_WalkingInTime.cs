using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        int[] credits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var (a, b, c) = (credits[0], credits[1], credits[2]);

        if (a == b || a == c || b == c || a + b == c || a + c == b || b + c == a)
            Console.WriteLine('S');
        else
            Console.WriteLine('N');
    }
}