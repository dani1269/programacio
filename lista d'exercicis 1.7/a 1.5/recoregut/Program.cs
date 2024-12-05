using System;

class Program
{
    static void Main(string[] args)
    {
       
        const int MARCA_FI = 0;
        int valor;
        int nValors = 0;

        valor = Convert.ToInt32(Console.ReadLine());
   
        while (valor != MARCA_FI)
        {
            nValors += 1; 
            Console.WriteLine($"Interació {nValors} ---> {valor}"); 
            valor = Convert.ToInt32(Console.ReadLine()); 
        }

        Console.WriteLine($"TOTAL VALORS INTRODUÏTS: {nValors}");
    }
}
