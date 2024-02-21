using System; 

class URI 
{
    static void Main(string[] args) 
    { 
        int product1Code, product2Code, product1Units, product2Units;
        double product1Price, product2Price, totalAmount;
            
        string[] values = Console.ReadLine().Split(' ');
        product1Code = int.Parse(values[0]);
        product1Units = int.Parse(values[1]);
        product1Price = double.Parse(values[2]);

        values = Console.ReadLine().Split(' ');
        product2Code = int.Parse(values[0]);
        product2Units = int.Parse(values[1]);
        product2Price = double.Parse(values[2]);

        totalAmount = product1Units * product1Price + product2Units * product2Price;

        Console.WriteLine("VALOR A PAGAR: R$ " + totalAmount.ToString("F2"));
    }
}