using System;

class URI 
{
    static void Main(string[] args) 
    {
        for (int i = 1; i < 6; i++)
            Console.WriteLine($"{new string(' ', 8 - i)}{(char)('A' + i - 1)}{(i > 1 ? new string(' ', 2 * i - 3) + (char)('A' + i - 1) : "")}");
            
        for (int i = 4; i > 0; i--)
            Console.WriteLine($"{new string(' ', 8 - i)}{(char)('A' + i - 1)}{(i > 1 ? new string(' ', 2 * i - 3) + (char)('A' + i - 1) : "")}");
    }
}