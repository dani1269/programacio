using System.Globalization;

namespace ex_5_a_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-us");

            const string FILE_NAME = "coordenades3.txt";
            StreamReader fPunts;
            string linia;
            double radi;
            double distancia;
            double x;
            double y;

            Console.WriteLine("entra el valor del radi");
            radi = Convert.ToInt32 (Console.ReadLine());

            fPunts = new StreamReader(FILE_NAME);

            linia = fPunts.ReadLine();

            while (linia != null)
            {
                x = Convert.ToDouble (linia);

                linia = fPunts.ReadLine();
                y = Convert.ToDouble(linia);
                
                distancia = Math.Sqrt(x * x + y * y);

                if (distancia <= radi)
                {
                    Console.WriteLine($"({x}, {y}) està dins del radi.");
                }
                else
                {
                    Console.WriteLine($"({x}, {y}) està fora del radi.");
                }

                linia = fPunts.ReadLine();

            }
        }
    }
}
