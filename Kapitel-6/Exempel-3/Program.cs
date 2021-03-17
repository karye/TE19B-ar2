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

        /// <summary>
        /// Metod för att summera två heltal
        /// </summary>
        /// <param name="x">Första heltalet</param>
        /// <param name="y">Andra heltalet</param>
        /// <returns>Summan</returns>
        static int Summera(int x, int y)
        {
            int z = x + y;
            return z;
        }

        /// <summary>
        /// Metod för att vända på en text
        /// </summary>
        /// <param name="text">Text som skall vändas</param>
        /// <returns>Omvända texten</returns>
        static string VändText(string text)
        {
            //...
            string resultat = ..

            return resultat;
        }
    }
}
