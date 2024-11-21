using System;
using System.IO;
using System.Globalization;

class Programa
{
    static void Main()
    {
        string path = "/mnt/data/tiquetsuper.txt"; 

        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);
            int productes = int.Parse(lines[0]); 
            double preuTotal = 0.0;
            int index = 1;

            for (int i = 0; i < productes; i++)
            {
                string nom = lines[index]; 
                double quantitat = double.Parse(lines[index + 1], CultureInfo.InvariantCulture); 
                double preuPaquet = double.Parse(lines[index + 2].Replace(",", "."), CultureInfo.InvariantCulture); 

                preuTotal += quantitat * preuPaquet;
                index += 3; 
            }

            Console.WriteLine("Preu total de la compra: " + preuTotal.ToString("F2") + " €");
        }
        else
        {
            Console.WriteLine("El fitxer no existeix.");
        }
    }
}

