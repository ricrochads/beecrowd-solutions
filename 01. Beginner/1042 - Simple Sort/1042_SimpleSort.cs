using System;

class URI 
{
    static void Main(string[] args) 
    {
        string[] numbers = Console.ReadLine().Split(' ');

        int a = int.Parse(numbers[0]);
        int b = int.Parse(numbers[1]);
        int c = int.Parse(numbers[2]);

        if (a <= b && b <= c)
            Console.WriteLine($"{a}\n{b}\n{c}");
        else if (a <= c && c <= b)
            Console.WriteLine($"{a}\n{c}\n{b}");
        else if (b <= a && a <= c)
            Console.WriteLine($"{b}\n{a}\n{c}");
        else if (b <= c && c <= a)
            Console.WriteLine($"{b}\n{c}\n{a}");
        else if (c <= a && a <= b)
            Console.WriteLine($"{c}\n{a}\n{b}");
        else
            Console.WriteLine($"{c}\n{b}\n{a}");

        Console.WriteLine($"\n{a}\n{b}\n{c}");
    }
}