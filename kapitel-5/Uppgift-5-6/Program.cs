using System;

namespace Uppgift_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en tom array med plats för 5 string
            string[] städer = new string[5];
            //string[] städer = {"", "", "", "", ""};

            // Fyll array, string-för-string
            for (int i = 0; i < städer.Length; i++)
            {
                städer[i] = Console.ReadLine();
            }

            // Skriv ut arrayen med en foreach-loop
            foreach (var stad in städer)
            {
                Console.WriteLine(stad);
            }
        }
    }
}
