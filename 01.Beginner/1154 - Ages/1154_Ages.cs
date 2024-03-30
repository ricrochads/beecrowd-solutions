using System;
using System.Collections.Generic;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        int age = int.Parse(Console.ReadLine());
        List<double> ages = new List<double>();

        while (age >= 0)
        {
            ages.Add(age);
            age = int.Parse(Console.ReadLine());
        }

        double averageAge = ages.Sum() / ages.Count;

        Console.WriteLine($"{averageAge:F2}");
    }
}