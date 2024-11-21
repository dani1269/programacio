using System;

class Program
{
    static void Main()
    {
        
        Console.Write("ENTRA n1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("ENTRA n2: ");
        int n2 = int.Parse(Console.ReadLine());

      
        for (int i = n1; i <= n2; i++)
        {
            Console.Write(i);

           
            if (i < n2)
            {
                Console.Write(", ");
            }
        }
    }
}
