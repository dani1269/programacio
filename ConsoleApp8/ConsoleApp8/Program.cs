using System.Runtime.CompilerServices;
using System.Security;
using System.Threading.Channels;

namespace ConsoleApp8
{
    internal class Program
    {
        private static object alumne;

        static void Main(string[] args)
        {
            // Atributs de l'alumne
            String nom;
            int edat;
            String telefon;
            String email;
            String sexe;
            char sexe2;
            int sexe3;

            nom = "Artur";
            edat =18;
            telefon = "+34-654823091";
            email = "athur@gmail.com";
            sexe = "home";
            sexe2 = 'H';
            sexe3 = 0;
        
            Console.WriteLine("nom,edat,sexe,email,telefon");
            Console.WriteLine($"{nom}.{edat},{telefon},{email},{sexe}");








        }

        private static void ConsoleWriteLine()
        {
            throw new NotImplementedException();
        }

        private static void print(object f, string v)
        {
            throw new NotImplementedException();
        }
    }
}
