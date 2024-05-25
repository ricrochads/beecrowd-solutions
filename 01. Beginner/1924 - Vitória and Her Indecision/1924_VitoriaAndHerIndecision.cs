using System;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        List<string> courses = new List<string>();
        
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            courses.Add(s);
        }

        if (!courses.Contains("Ciencia da Computacao"))
            courses.Add("Ciencia da Computacao");

        Console.WriteLine("Ciencia da Computacao");
    }
}