using System;

class URI 
{
    static void Main(string[] args)
    {
        while (true)
        {
            double score1 = GetValidScore();
            double score2 = GetValidScore();
            double average = (score1 + score2) / 2;

            Console.WriteLine($"media = {average:F2}");

            int option = GetValidOption("novo calculo (1-sim 2-nao)");

            if (option == 2)
                break;
        }
    }

    static double GetValidScore()
    {
        double score;

        while (true)
        {
            string input = Console.ReadLine();

            if (double.TryParse(input, out score) && score >= 0 && score <= 10)
                break;
            else
                Console.WriteLine("nota invalida");
        }

        return score;
    }

    static int GetValidOption(string message)
    {
        while (true)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int option) && (option == 1 || option == 2))
                return option;
        }
    }
}