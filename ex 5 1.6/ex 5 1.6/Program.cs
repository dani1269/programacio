using System;

class Program
{
    static void Main()
    {
       
        double suma = 0;

       
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Introdueix el número {i}: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            suma += numero; 
        }

    
        Console.WriteLine($"La suma total dels 10 números és: {suma}");
    }
}

