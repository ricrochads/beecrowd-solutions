using System;

class URI 
{
    static void Main(string[] args) 
    {
        float[] scores = new float[2];
        int validScores = 0;

        while (validScores < 2)
        {
            scores[validScores] = float.Parse(Console.ReadLine());

            if (scores[validScores] < 0 || scores[validScores] > 10)
                Console.WriteLine("nota invalida");
            else
                validScores++;
        }
        
        float average = (scores[0] + scores[1]) / 2;
        Console.WriteLine($"media = {average:F2}");
    }
}