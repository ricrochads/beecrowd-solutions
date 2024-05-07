using System;
using System.Linq;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < 100; i++)
        {
            int n = int.Parse(Console.ReadLine());
            numbers.Add(n);  
        }

        Console.WriteLine(numbers.Max());
        Console.WriteLine(numbers.IndexOf(numbers.Max()) + 1);
    }
}