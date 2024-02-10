using System; 

class URI 
{
    static void Main(string[] args) 
    {
        int time, distance;

        distance = int.Parse(Console.ReadLine());

        time = distance * 2;

        Console.WriteLine(time + " minutos");
    }
}