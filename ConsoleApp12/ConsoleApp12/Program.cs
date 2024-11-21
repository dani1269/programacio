namespace ConsoleApp12
{
    internal class Program
    {


    
       
        public static bool EsParell(int n)
        {
            return n % 2 == 0;
        }

        
        public static bool EsMultipleDe7(int n)
        {
            return n % 7 == 0;
        }

        static void Main(string[] args)
        {
            
            Console.Write("Introdueix un nombre enter: ");
            int nombre = int.Parse(Console.ReadLine());

            
            if (EsParell(nombre))
            {
                Console.WriteLine("El nombre és parell.");
            }
            else
            {
                Console.WriteLine("El nombre és senar.");
            }

            
            if (EsMultipleDe7(nombre))
            {
                Console.WriteLine("El nombre és múltiple de 7.");
            }
            else
            {
                Console.WriteLine("El nombre no és múltiple de 7.");
            }
        }

    }

}

