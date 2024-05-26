using System;

class URI 
{
    static void Main(string[] args) 
    {
        string s = Console.ReadLine(); 
        int count = 0;

        foreach (char bit in s)
        {
            if (bit == '1')
                count++;
        }       

        char b = (count % 2 == 0) ? '0' : '1';
        Console.WriteLine(s + b);
    }
}