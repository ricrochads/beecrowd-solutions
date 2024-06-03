using System;

class URI 
{
    static void Main(string[] args) 
    {
        for (double i = 0; i <= 2; i += 0.2)
        {
            for (double j = 1; j <= 3; j++)
                Console.WriteLine($"I={i:0.#} J={j + i:0.#}");
        }
    }
}