using System;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        int t;

        Dictionary<int, string> teaType = new Dictionary<int, string>()
        {
            {1, "white tea"},
            {2, "green tea"},
            {3, "black tea"},
            {4, "herbal tea"}
        };

        do
        {
            t = Convert.ToInt32(Console.ReadLine());
        } while (!teaType.ContainsKey(t));

        int[] answers = new int[5];
        answers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int correctAnswer = 0;

        foreach(int answer in answers)
        {
            if (t == answer)
                correctAnswer++;
        }

        Console.WriteLine(correctAnswer);
    }
}