using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        
        int currentNumber = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{currentNumber += 1} {currentNumber += 1} {currentNumber += 1} PUM");
            currentNumber++;
        }
    }
}