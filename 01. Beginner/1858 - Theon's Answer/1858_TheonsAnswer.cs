using System;
using System.Linq;

class URI
{
    static void Main(string[] args) 
    {
        int n;

        do
            n = int.Parse(Console.ReadLine());
        while (n < 1 || n > 100);

        string[] input = Console.ReadLine().Split(' ');
        int[] t = new int[n];

        for (int i = 0; i < n; i++)
            t[i] = int.Parse(input[i]);

        int min = t.Min();
        int personNumber = 0;
        
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == min)
            {
                personNumber = i + 1;
                break;
            }
        }
        
        Console.WriteLine(personNumber);
    }
}