using System;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        string[] input = Console.ReadLine().Split(' ');
        Dictionary<int, string> c = new Dictionary<int, string>();

        for (int i = 0; i < input.Length; i++)
        {
            c[i + 1] = input[i];

            if (c[i + 1] == "1")
                Console.WriteLine(i + 1);
        }
    }
}