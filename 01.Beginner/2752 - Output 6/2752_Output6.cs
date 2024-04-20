using System;

class URI 
{
    static void Main(string[] args) 
    {
        string phrase = "AMO FAZER EXERCICIO NO URI";

        Console.WriteLine($"<{phrase}>");
        Console.WriteLine($"<{phrase, 30}>");
        Console.WriteLine($"<{phrase.Substring(0, 20)}>");
        Console.WriteLine($"<{phrase, -20}>");
        Console.WriteLine($"<{phrase, -30}>");
        Console.WriteLine($"<{phrase}>");
        Console.WriteLine($"<{phrase.Substring(0, 20), 30}>");
        Console.WriteLine($"<{phrase.Substring(0, 20), -30}>");
    }
}