using System; 

class URI 
{
    static void Main(string[] args) 
    {
        double averageSpeed, time, distance, liters;

        time = double.Parse(Console.ReadLine());
        averageSpeed = double.Parse(Console.ReadLine());

        distance = averageSpeed * time;
        liters = distance / 12;

        Console.WriteLine(liters.ToString("F3"));
    }
}