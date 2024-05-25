using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        var cards = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var (a, b) = (cards[0], cards[1]);

        if (a == b)
            Console.WriteLine(a);
        else if (a > b)
            Console.WriteLine(a);
        else
            Console.WriteLine(b);
    }
}