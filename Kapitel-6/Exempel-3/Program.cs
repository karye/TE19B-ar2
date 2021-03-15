using System;

namespace Exempel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = Summera(99, 123);

            string omvändText = VändText("Programmering");
        }

        // Metod för att summera två tal
        // Returnerar ett heltal
        static int Summera(int x, int y)
        {
            int z = x + y;
            return z;
        }

        // Metod för att vända på en text
        // Returnerar en string
        static string VändText(string text)
        {
            //...
            string resultat = ..

            return resultat;
        }
    }
}
