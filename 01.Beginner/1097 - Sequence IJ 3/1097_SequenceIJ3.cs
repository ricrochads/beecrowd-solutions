using System;

class URI 
{
    static void Main(string[] args) 
    {
        int i = 1;
        int j = 7;

        do
        {
            for (int index = 0; index < 3; index++)
            {
                Console.WriteLine($"I={i} J={j - index}");
            }
            i += 2;
            j += 2;
        } while (i <= 9);
    }
}