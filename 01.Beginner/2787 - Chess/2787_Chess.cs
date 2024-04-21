using System;

class URI 
{
    static void Main(string[] args) 
    {
        int l = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if ((l + c) % 2 == 0)
            Console.WriteLine(1);
        else
            Console.WriteLine(0);
    }
}