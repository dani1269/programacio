using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {

        string filePath = "/mnt/data/alumnesDAMDAW (1).txt";

        try
        {

            string[] alumnes = File.ReadAllLines(filePath);


            int alexCount = alumnes.Count(alumne => alumne.Trim() == "Alex");
            int ikerCount = alumnes.Count(alumne => alumne.Trim() == "Iker");


            if (alexCount > ikerCount)
            {
                Console.WriteLine($"Hi ha més alumnes que es diuen Alex ({alexCount}) que Iker ({ikerCount}).");
            }
            else if (ikerCount > alexCount)
            {
                Console.WriteLine($"Hi ha més alumnes que es diuen Iker ({ikerCount}) que Alex ({alexCount}).");
            }
            else
            {
                Console.WriteLine($"Hi ha el mateix nombre d'alumnes que es diuen Alex i Iker ({alexCount}).");
            }
        }
        catch (Exception ex)
        { 


    }
    }
}

