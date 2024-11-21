using System;

class TaulesDeMultiplicar
{
    
    static void MostrarTaula(int numTaula)
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{numTaula} x {i} = {numTaula * i}");
        }
        Console.WriteLine(); 
    }

    static void Main()
    {
        
        for (int i = 0; i <= 10; i++)
        {
            MostrarTaula(i);
        }
    }
}
