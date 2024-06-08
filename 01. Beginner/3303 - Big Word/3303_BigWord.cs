using System;

class URI 
{
    static void Main(string[] args) 
    {
        string word;

        while ((word = Console.ReadLine()?.Trim()) != null)
        {
            if (word.Length >= 10)
                Console.WriteLine("palavrao");
            else
                Console.WriteLine("palavrinha");
        }
    }
}