using System;

namespace Uppgift_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en array med minst 5 heltal
            //int[] talLista = new int[5];  // En tom array med plats för 5 tal
            //int[] talLista = new int[5] {23, 45, 34, 22, 12}; // En array med 5 tal
            int[] talLista = {23, 45, 34, 22, 12}; // En array med 5 tal

            // Beräkna summan av alla heltal i arrayen med hjälp av en foreach-loop
            int summa = 0;
            foreach (var tal in talLista)
            {
                summa += tal;
            }

            // Skriv ut summan
            Console.WriteLine($"Summan är {summa}");
        }
    }
}
