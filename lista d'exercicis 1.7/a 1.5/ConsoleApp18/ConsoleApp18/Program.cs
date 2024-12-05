using System;
using System.IO;

class Program
{
    const string MARCA_FI = null;  
    static void Main()
    {
        
        Random rand = new Random();
        string line;
        int totalTickets = 0;
        int bonusCount = 0;
        int totalAmount = 0;

    
        using (StreamReader reader = new StreamReader("bonus.txt"))
        {
            
            line = reader.ReadLine();

            while (line != MARCA_FI)
            {
                
                totalTickets++;

            
                if (line == "BONUS")
                {
                    bonusCount++;
                    int bonusAmount = rand.Next(1, 11);  
                    totalAmount += bonusAmount;
                }

                
                line = reader.ReadLine();
            }
        }

       
        if (totalTickets == 0)
        {
            Console.WriteLine("El fitxer està buit.");
        }
        else
        {
           
            double bonusPercentage = (double)bonusCount / totalTickets * 100;
  
            Console.WriteLine($"Nombre total de bitllets: {totalTickets}");
            Console.WriteLine($"Nombre de bitllets amb BONUS: {bonusCount}");
            Console.WriteLine($"Percentatge de bitllets amb BONUS: {bonusPercentage:F2}%");
            Console.WriteLine($"Import total dels guanys: {{totalAmount}}€");


        }

    }
}
