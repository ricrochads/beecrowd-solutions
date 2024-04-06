using System;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var (t1, t2, t3, t4) = (line[0], line[1], line[2], line[3]);

        int maxDevicesConnected = t1 + t2 + t3 + t4 - 3;

        Console.WriteLine(maxDevicesConnected);
    }
}