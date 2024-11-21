using System;

class Program
{
    static void Main()
    { 
      
        Console.Write("ENTRAUNNÚMERO: ");
        int n = int.Parse(Console.ReadLine());

      
        int suma = 0;
        for (int i = 1; i <= n; i++)
        {
            suma += i;
        }

       
        Console.WriteLine(suma);
    }
}

