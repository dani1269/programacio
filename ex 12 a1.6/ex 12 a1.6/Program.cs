using System;
using System.IO;

class Program
{
    private static double x;
    private static double y;

    static void Main(string[] args)
    {
        const string File_name = "COORDENADES2.TXT"; 
        
        Console.WriteLine("Introdueix el radi de la circumferència: ");
        double radi = Convert.ToDouble(Console.ReadLine());

        try
        {
            
            using (StreamReader fPunts = new StreamReader(File_name))
            {
               
                int numPunts = int.Parse(fPunts.ReadLine());

              
                for (int i = 0; i < numPunts; i++)
                {
                    x = double.Parse(fPunts.ReadLine()); 
                    y = double.Parse(fPunts.ReadLine()); 

                    // Calculem la distància del punt (x, y) respecte a l'origen
                    double distancia = Distancia(x, y);

                    
                    if (distancia < radi)
                    {
                        Console.WriteLine($"El punt ({x}, {y}) està dins de la circumferència.");
                    }
                    else if (distancia == radi)
                    {
                        Console.WriteLine($"El punt ({x}, {y}) està sobre el perímetre de la circumferència.");
                    }
                    else
                    {
                        Console.WriteLine($"El punt ({x}, {y}) està fora de la circumferència.");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en llegir el fitxer o processar les coordenades: {ex.Message}");
        }
    }

    // Funció per calcular la distància d'un punt a l'origen (0, 0)
    static double Distancia(double x, double y)
    {
        return Math.Sqrt(x * x + y * y); // Teorema de Pitàgores
    }
}

