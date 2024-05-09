using System;

class URI 
{
    static void Main(string[] args) 
    {
        bool accessGranted = false;

        while (!accessGranted)
        {
            int password = int.Parse(Console.ReadLine());

            switch (password)
            {
                case 2002:
                    Console.WriteLine("Acesso Permitido");
                    accessGranted = true;
                    break;
                default:
                    Console.WriteLine("Senha Invalida");
                    break;
            }
        }
    }
}