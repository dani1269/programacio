using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    
    const string FILE_NAME = "NUMEROS.TXT"; 

    static void Main()
    {
        
        StreamReader fnumeros = new StreamReader(FILE_NAME); 
        string linia = fnumeros.ReadLine(); 
        int primerNumero = Convert.ToInt32(linia.Trim()); 
        int numeroActual = 0; 
        bool trobat = false; 
        bool fi = false; 
        List<int> seenNumbers = new List<int>(); 

        seenNumbers.Add(primerNumero);

        
        while (!fi && !trobat)
        {
            linia = fnumeros.ReadLine();
            fi = linia == null;  

            numeroActual = fi?0Convert.ToInt32(linia.Trim()); 

            trobat = (numeroActual == primerNumero) && !fi; 

            seenNumbers.Add(numeroActual);

            
        }
    
        Console.WriteLine(trobat ? "El primer número es repeteix." : "No es repeteix cap número.");

        fnumeros.Close();
    }
}

