using System;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        int number;

        do
            number = int.Parse(Console.ReadLine());
        while (number <= 0 || number > 12);

        Dictionary<int, string> months = new Dictionary<int, string>()
        {
            { 1, "January" },
            { 2, "February" },
            { 3, "March" },
            { 4, "April" },
            { 5, "May" },
            { 6, "June" },
            { 7, "July" },
            { 8, "August" },
            { 9, "September" },
            { 10, "October" },
            { 11, "November" },
            { 12, "December" },
        };
        
        Console.WriteLine(months[number]);
    }
}