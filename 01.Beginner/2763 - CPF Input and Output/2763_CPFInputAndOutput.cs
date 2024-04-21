using System;

class URI 
{
    static void Main(string[] args) 
    {
        string[] cpf = Console.ReadLine().Split('.', '-');

        foreach (string cpfPart in cpf)
            Console.WriteLine(cpfPart);
    }
}