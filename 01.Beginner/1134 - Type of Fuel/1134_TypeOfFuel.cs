using System;

class URI 
{
    static void Main(string[] args) 
    {
        int option = int.Parse(Console.ReadLine());
        
        int diesel = 0;
        int alcohol = 0;
        int gasoline = 0;

        while (option != 4)
        {
            switch (option)
            {
                case 1:
                    alcohol++;
                    break;
                case 2:
                    gasoline++;
                    break;
                case 3:
                    diesel++;
                    break;
                default:
                    break;
            }
            option = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcohol);
        Console.WriteLine("Gasolina: " + gasoline);
        Console.WriteLine("Diesel: " + diesel);
    }
}