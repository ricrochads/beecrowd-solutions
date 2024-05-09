using System;

class URI 
{
    static void Main(string[] args) 
    {
        while (true)
        {
            string[] coordinates = Console.ReadLine().Split(' ');

            int xCoordinate = int.Parse(coordinates[0]);
            int yCoordinate = int.Parse(coordinates[1]);

            if (xCoordinate > 0 && yCoordinate > 0)
                Console.WriteLine("primeiro");
            else if (xCoordinate < 0 && yCoordinate > 0)
                Console.WriteLine("segundo");
            else if (xCoordinate < 0 && yCoordinate < 0)
                Console.WriteLine("terceiro");
            else if (xCoordinate > 0 && yCoordinate < 0)
                Console.WriteLine("quarto");
            else
                break;
        }
    }
}