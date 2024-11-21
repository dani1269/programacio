using System;
using System.IO;

class Program
{
    
    static int PassarASegons(int hores, int minuts, int segons)
    {
        return (hores * 3600) + (minuts * 60) + segons;
    }

    static void Main()
    {
        
        int minTemps = 100000;  
        int maxTemps = -1;      
        int dorsalGuanyador = -1;     
        int dorsalPitjor = -1;        

        
        string fitxerPath = "CURSA.TXT";

        
        if (!File.Exists(fitxerPath))
        {
            Console.WriteLine("El fitxer CURSA.TXT no existeix.");
            return;  
        }

        
        foreach (string line in File.ReadLines(fitxerPath))
        {
            
            if (line == "")
                continue;

            
            string[] parts = line.Split();  

            
            if (parts.Length != 2)
            {
                Console.WriteLine("Línia incorrecta: " + line);
                continue;  
            }

            
            int dorsal = int.Parse(parts[0]);

           
            string tempsStr = parts[1];

           
            int hores = int.Parse(tempsStr.Substring(0, 2));  
            int minuts = int.Parse(tempsStr.Substring(2, 2)); 
            int segons = int.Parse(tempsStr.Substring(4, 2)); 
           
            int tempsEnSegons = PassarASegons(hores, minuts, segons);

            
            Console.WriteLine($"DORSAL {dorsal}: {tempsEnSegons} SEGONS");

            
            if (tempsEnSegons < minTemps)
            {
                minTemps = tempsEnSegons;  
                dorsalGuanyador = dorsal;  
            }

            if (tempsEnSegons > maxTemps)
            {
                maxTemps = tempsEnSegons;  
                dorsalPitjor = dorsal;  
            }
        }
        
        Console.WriteLine($"DORSAL GUANYADOR: {dorsalGuanyador}");
        Console.WriteLine($"PITJOR DORSAL: {dorsalPitjor}");
    }
}

