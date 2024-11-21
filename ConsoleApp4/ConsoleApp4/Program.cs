internal class Program
{
    private static double Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ///summary 
        ///calcular el sou brut del treballador 
        ///summary 
        ///<parametre name>Hores treballades</parametre>
        ///<parametre name>Preu l'hora</parametre>
        ///<return>Retorns el sou brut del trebllador</return>
        private static double CalcularSouBrut(int hores, double preuHora);
        {
            double sou;
            sou = NewMethod() * GetPreuHora();
            return sou;

            ///summary 
            ///calcular liquidacio 
            ///summary
            ///<parametre name></parametre>
            /// <param name="salBrut">Salari brut</param>
            /// <param name="percentImpost">Impost en percentatge</param>
            /// <returns>Retorna la retenció</returns>
            private static double CalcularRetencio(double salBrut, double percentImpost)
            {
                double reten;
                reten = salBrut * percentImpost / 100;
                return reten;
            }

            ///summaru 
            ///calcular sou net del treballador 
            ///summary 
            ///<parametre name>sou brut </parametre>
            ///<parametre name>retenció</parametre>
            ///<returns>Retorna el sou net</returns>
            ///<exception cref="NotImplementedException"></exception>
            private static double CalcularSouNet(double sBrut, double reten)
            {
                double souNet;
                souNet = sBrut - reten;
                return souNet;
            }


        }
    }

    private static object NewMethod()
    {
        return GetHores();
    }

    private static object GetHores()
    {
        return hores;
    }

    private static object GetPreuHora()
    {
        return preuHora;
    }
}
