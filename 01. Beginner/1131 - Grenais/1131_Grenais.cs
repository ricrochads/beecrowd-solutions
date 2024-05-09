using System;

class URI 
{
    static void Main(string[] args) 
    {
        string[] goalsScored = Console.ReadLine().Split(' ');

        int grenais = 0;
        int interWins = 0;
        int gremioWins = 0;
        int draws = 0;
        
        bool continueLoop = true;

        while (continueLoop)
        {
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            
            int interGoalsScored = int.Parse(goalsScored[0]);
            int gremioGoalsScored = int.Parse(goalsScored[1]);

            if (interGoalsScored > gremioGoalsScored)
            {
                interWins++;
                grenais++;
            }
            else if (gremioGoalsScored > interGoalsScored)
            {
                gremioWins++;
                grenais++;
            }
            else
            {
                draws++;
                grenais++;
            }
            
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    goalsScored = Console.ReadLine().Split(' ');
                    break;
                case 2:
                    Console.WriteLine($"{grenais} grenais");
                    Console.WriteLine($"Inter:{interWins}");
                    Console.WriteLine($"Gremio:{gremioWins}");
                    Console.WriteLine($"Empates:{draws}");
                    if (interWins > gremioWins)
                        Console.WriteLine("Inter venceu mais");
                    else if (gremioWins > interWins)
                        Console.WriteLine("Gremio venceu Mais");
                    else 
                        Console.WriteLine("Não houve vencedor");
                    continueLoop = false;
                    break;
            }
        }
    }
}