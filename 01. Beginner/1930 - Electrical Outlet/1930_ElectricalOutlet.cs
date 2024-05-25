using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        var integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var (t1, t2, t3, t4) = (integers[0], integers[1], integers[2], integers[3]);

        int maxDevicesConnected = t1 + t2 + t3 + t4 - 3;

        Console.WriteLine(maxDevicesConnected);
    }
}