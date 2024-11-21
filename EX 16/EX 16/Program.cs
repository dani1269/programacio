using System;

class Program
{
   
    public static string GenerarLinia(char car, int longitud)
    {
        return new string(car, longitud);
    }

    static void Main()
    {
        
        Console.Write("ENTRAUNNÚMERO: ");
        int num = ToI32(Console.ReadLine());


        for (int i = 1; i <= num; i++)
        {
            
            string linia = GenerarLinia('*', i);
            Console.WriteLine(linia);
        }
    }
}
