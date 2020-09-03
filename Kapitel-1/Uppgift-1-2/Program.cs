/* 
Ett program som skriver flera rader text.
 */

using System;

namespace Uppgift_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Denna skriver ut text
            /* Console.WriteLine("Detta är ett program gjort i C#.");
            Console.WriteLine("Programmet skriver ut text på flera rader.");
            Console.WriteLine("Detta är programmets sista utskrift."); */

            Console.WriteLine("Detta är ett \"program\" gjort i C#.\n" +
            "\\Programmet skriver ut text på flera rader.\n" +
            "Detta\tär\tprogrammets\tsista\tutskrift.");
        }
    }
}
