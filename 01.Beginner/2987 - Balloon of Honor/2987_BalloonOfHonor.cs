using System;

class URI 
{
    static void Main(string[] args) 
    {
        char l = Console.ReadLine()[0];

        l = char.ToUpper(l);
        int position = l - 'A' + 1;
        
        Console.WriteLine(position);        
    }
}