using System;
using System.IO;

class Programa
{
    static void Main()
    {
    
        string rutaFitxer = @"/mnt/data/BONUS2.TXT";

       
        int totalBonus = 0;
        int comptadorBonus = 0;

        
        string[] linies = File.ReadAllLines(rutaFitxer);

        
        for (int i = 0; i < linies.Length; i++)
        {
         
            string linia = linies[i].Trim();

          
            if (linia == "BONUS")
            {
                comptadorBonus++; 

               
                if (i + 1 < linies.Length)
                {
                    
                    if (int.TryParse(linies[i + 1].Trim(), out int quantitatBonus))
                    {
                        totalBonus += quantitatBonus;  
                    }
                }

                i++; 
            }
        }

      
        Console.WriteLine("Total de la quantitat de BONUS: " + totalBonus);
        Console.WriteLine("Nombre de línies amb BONUS: " + comptadorBonus);
    }
}

