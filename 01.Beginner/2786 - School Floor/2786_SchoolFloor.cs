using System;

class URI 
{
    static void Main(string[] args) 
    {
        int l = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        
        int tiles1 = l * c + ((l - 1) * (c - 1));
        int tiles2 = l * 2 + c * 2 - 4;

        Console.WriteLine(tiles1);
        Console.WriteLine(tiles2);
    }
}