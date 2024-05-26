using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        int x, m, e;
        int[] exp = new int[2];

        while ((exp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray())[0] != 0 && exp[1] != 0)
        {
            (x, m) = (exp[0], exp[1]);
            e = m * x;
            Console.WriteLine(e);
        }
    }
}