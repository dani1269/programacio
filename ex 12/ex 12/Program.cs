using System;

class Program
{
    static void Main()
    {
      
        Console.Write("ENTRA UN NÚMERO: ");
        int num = int.Parse(Console.ReadLine());

       
        int suma = 0;

        
        for (int i = 1; i <= num; i++)
        {
            suma += i; 
        }

        
        Console.WriteLine(suma);
    }
}

