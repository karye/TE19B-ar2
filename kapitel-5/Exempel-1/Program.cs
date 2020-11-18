using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alt 1: Här skapar vi en array på 3 strings
            // Skapa en array av tre städers namn: "Stockholm", "Paris", "London"
            string[] städer = {"Stockholm", "Paris", "London"}; // Låst till 3!

            // Skriver ut innehållet
            // städer[0] = "Stockholm"; // index = 0
            // städer[1] = "Paris";     // index = 1
            // städer[2] = "London";    // index = 2

            // Alt 2: skapa en tom array på 2 strings
            string[] länder = new string[2];

            // Skapa en annan array av 3 tal
            int[] årtal = new int[3];

            // Fylla en array
            länder[0] = "Frankrike";
            länder[1] = "Polen";

            årtal[0] = 1945;
            årtal[1] = 1975;
            årtal[2] = 2000;

            // Skriv ut alla årtalen i arrayen årtal
            for (int i = 0; i < årtal.Length; i++) // .Length = antalet = 3
            {
                Console.Write(årtal[i]); // årtal[0], årtal[1], årtal[2]
            }

        }
    }
}
