using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Introdueix un número enter positiu: ");
        int n = Convert.ToInt32(Console.ReadLine());

        
        int suma = 0;

        
        for (int i = 1; i <= n; i++)
        {
            suma += i;

            
            for (int j = 1; j <= i; j++)
            {
                
                if (j > 1) Console.Write("+");
                Console.Write(j);
            }

            
            Console.WriteLine("=" + suma);
        }
    }
}
