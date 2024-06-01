using System;

class URI 
{
    static void Main(string[] args) 
    {
        int c, n;

        c = int.Parse(Console.ReadLine());

        for (int i = 0; i < c; i++)
        {
            n = int.Parse(Console.ReadLine());

            if (n > 8000)
                Console.WriteLine("Mais de 8000!");
            else
                Console.WriteLine("Inseto!");
        }
    }
}