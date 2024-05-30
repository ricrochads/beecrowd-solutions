using System;

class URI 
{
    static void Main(string[] args) 
    {
        int c;
        string question;
        string answer = "gzuz";

        do
            c = int.Parse(Console.ReadLine());
        while (c < 2 || c > 99);

        for (int i = 0; i < c; i++)
        {
            question = Console.ReadLine();
            Console.WriteLine(answer);
        }
    }
}