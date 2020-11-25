using System;

namespace MorseTolk
{
    class Program
    {
        static void Main(string[] args)
        {
            // Berätta om programmet
            // Be om ett meddelande
            Console.WriteLine("Det här programmet översätter svenska till morsekod.");
            Console.Write("Ange ett meddelande: ");
            string meddelande = Console.ReadLine().ToUpper();

            // Skapa en samling för alfabetet (string)
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ ";

            // Skapa en samling för morsekode (array)
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", "/" };

            // Loopa igenom meddelandet
            string morseMeddelande = "";
            for (int i = 0; i < meddelande.Length; i++)
            {
                // Skriv ut varje tecken
                string bokstav = meddelande[i].ToString();
                //Console.WriteLine($"{bokstav}");

                // Hitta bokstavens plats i alfabetet
                int index = alfabetet.IndexOf(bokstav);

                // Skriv ut morsekoden för bokstaven
                string morseBokstav = morse[index];
                //Console.WriteLine($"{bokstav}'s morsekod är {morseBokstav}");

                // Samla in hela meddelandet i morsekod
                morseMeddelande += morseBokstav;
            }

            // Skriv ut hela meddelandet i morsekod
            Console.WriteLine(morseMeddelande);
        }
    }
}
