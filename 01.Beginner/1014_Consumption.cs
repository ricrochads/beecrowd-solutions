using System; 

class URI 
{
    static void Main(string[] args) 
    { 
        double distance, fuelSpent, averageConsumption;

        distance = int.Parse(Console.ReadLine());
        fuelSpent = double.Parse(Console.ReadLine());

        averageConsumption = distance / fuelSpent;

        Console.WriteLine(averageConsumption.ToString("F3") + " km/l");
    }
}