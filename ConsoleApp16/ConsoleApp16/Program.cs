using System;

namespace ConsoleApp16
{
    private static void Main()
        {
            Console.Write("Introdueix un número enter positiu: ");
            int numero = int.Parse(Console.ReadLine());

            // Comprovar que el número és positiu
            if (numero <= 0)
            {
                Console.WriteLine("Si us plau, introdueix un número enter positiu.");
            }
            else
            {
                int xifres = 0;
                int n = numero;

                // Comptem el nombre de xifres
                while (n > 0)
                {
                    n /= 10;
                    xifres++;
                }

                Console.WriteLine($"El número {numero} té {xifres} xifres.");
            }
        }
    
}
