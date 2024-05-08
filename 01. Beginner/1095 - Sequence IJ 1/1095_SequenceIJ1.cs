using System;

class URI 
{
    static void Main(string[] args) 
    {
        int i = 1;
        int j = 60;

        do
        {
            Console.WriteLine($"I={i} J={j}");
            i+=3;
            j-=5;
        } while (j >= 0);
    }
}