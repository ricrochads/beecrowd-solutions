using System;

class URI 
{
    static void Main(string[] args) 
    {
        int input = int.Parse(Console.ReadLine());

        for (int question = 1; question <= input; question++)
        {
            int answer = int.Parse(Console.ReadLine());
            Console.WriteLine($"resposta {question}: {answer}");
        }
    }
}