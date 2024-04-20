using System;

class URI 
{
    static void Main(string[] args) 
    {
        int[] values = new int[26];

        for (int i = 0; i < values.Length; i++)
        {
            values[i] = 97 + i;
            Console.WriteLine($"{values[i]} e {(char)('a' + i)}");
        }
    }
}