namespace examen
{
    internal class Program
    {


        static void Main(string[] args)
        {
            double radi;
            double x1, y1;
            double x2, y2;
            double x3, y3;

           
            Console.Write("ENTRA EL RADI: ");
            radi = Convert.ToDouble(Console.ReadLine());

           
            Console.Write("ENTRA LA X1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTRA LA Y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

          
            Console.Write("ENTRA LA X2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTRA LA Y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

          
            Console.Write("ENTRA LA X3: ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTRA LA Y3: ");
            y3 = Convert.ToDouble(Console.ReadLine());

           
            Console.WriteLine(InfoPunt(radi, x1, y1));
            Console.WriteLine(InfoPunt(radi, x2, y2));
            Console.WriteLine(InfoPunt(radi, x3, y3));
        }


        public static double Distancia(double x, double y)
        {
            double dist;
            dist = Math.Sqrt(x * x + y * y);
            return dist;
        }


        public static string InfoPunt(double radi, double x, double y)
        {

            double distancia = Distancia(x, y);


            if (distancia < radi)
            {
                return $"EL PUNT ({x}, {y}) ESTÀ A DINS DE LA CIRCUMFERÈNCIA DE RADI {radi}.";
            }
            else if (distancia == radi)
            {
                return $"EL PUNT ({x}, {y}) ESTÀ EN EL PERÍMETRE DE LA CIRCUMFERÈNCIA DE RADI {radi}.";
            }
            else
            {
                return $"EL PUNT ({x}, {y}) ESTÀ A FORA DE LA CIRCUMFERÈNCIA DE RADI {radi}.";
            }
        }
    }

}
