using System;

class URI 
{
    static void Main(string[] args) 
    {
        string name = "Roberto";
        string number = "5786";
        string word = "UNIFEI";

        Console.WriteLine(new string('-', 39));
        Console.WriteLine("|" + new string(' ', 8) + name + new string(' ', 29 - name.Length) + "|");
        Console.WriteLine("|" + new string(' ', 37) + "|");
        Console.WriteLine("|" + new string(' ', 8) + number + new string(' ', 29 - number.Length) + "|");
        Console.WriteLine("|" + new string(' ', 37) + "|");
        Console.WriteLine("|" + new string(' ', 8) + word + new string(' ', 29 - word.Length) + "|");
        Console.WriteLine(new string('-', 39));
    }
}