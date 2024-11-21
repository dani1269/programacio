namespace ex_4__a_1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "NUMEROS.TXT";
            StreamReader FnUMEROS;
            string linia;
            int target;
            int pos;
            int numActual;
            bool trobat;

            Console.Write("entra un numero epr ha cercar");
            target=Convert.ToInt32(Console.ReadLine());

            FnUMEROS = new StreamReader(FILE_NAME);
            pos = 0;
            linia = FnUMEROS.ReadLine();

            while (!trobat && linia != null)
            {
            
             numActual=Convert.ToInt32(linia);
                if (numActual == target)
                {
                    trobat = true;  
                }
                else
                {
                    
                    pos++;
                    linia = FnUMEROS.ReadLine();
                }
            }

            if (trobat)
            {
                Console.WriteLine($"Número {target} s'ha tribat a la posició {pos}.");
            }
            else
            {
                Console.WriteLine($"Número {target} no s'ha trobat l'arxiu.");
            }

             
        }
        }
    }

