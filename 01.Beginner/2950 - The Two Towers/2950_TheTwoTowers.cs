using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        double[] input = new double[3];
        input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var (n, x, y) = (input[0], input[1], input[2]);

        double icm = n / (x + y);

        Console.WriteLine($"{icm:F2}");
    }
}