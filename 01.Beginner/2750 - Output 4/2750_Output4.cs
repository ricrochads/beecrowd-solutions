using System;

class URI 
{
    static void Main(string[] args) 
    {
        Console.WriteLine(new string('-', 39));
        Console.WriteLine("|  decimal  |  octal  |  Hexadecimal  |");
        Console.WriteLine(new string('-', 39));

        for (int i = 0; i < 16; i++)
            Console.WriteLine($"|{i, 7}    |{Convert.ToString(i, 8), 5}    |       {Convert.ToString(i, 16).ToUpper()}       |");

        Console.WriteLine(new string('-', 39));
    }
}

        
