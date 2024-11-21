namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        private class Prorram
        {
            static void Main(string[] args)
            {









                // Exersici 1: guarda i mostra les cordenades del punt p1
                (int, int) p1 = (2, 3);
                Console.WriteLine($"p1: {p1}");

                // Exersici 2: amplia el programa per guardar i mostrar els punts p1 i p2
                (int, int) p2 = (3, 1);
                Console.WriteLine($"p1: {p1}");
                Console.WriteLine($"p2: {p2}");

                // Exersici 3: mplia el programa per guardar i mostrar els punts p1,p2 i p3
                (int, double) p3 = (1, 2.5);
                Console.WriteLine($"p1: {p1}");
                Console.WriteLine($"p2: {p2}");
                Console.WriteLine($"p3: {p3}");

                // Exersici 4:Mostram les cordenades d'un format especific
                Console.WriteLine("\nCoordenades en format especificat:");
                Console.WriteLine($"p1: ({p1}, {p1})");
                Console.WriteLine($"p2: ({p2}, {p2})");
                Console.WriteLine($"p3: ({p3}, {p3})");
            }

            }
        }
    }

