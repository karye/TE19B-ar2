using System;

namespace Prov1b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presentation
            Console.WriteLine("Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.\n" +
                              "Marginalskatten räknas ut baserat på din bruttolön.\n" +
                              "Med bruttolön avses din årslön före skatt.");

            // Loopen!
            string igen = "j";
            while (igen == "j")
            {

                // Upprepa om användaren skriver in <= 0
                int bruttolön = 0;
                while (bruttolön <= 0)
                {
                    // Först matar användaren in bruttolönen
                    Console.Write("\nAnge din bruttolön i kronor: ");
                    string bruttolönSträng = Console.ReadLine();                    // Tex fel 'a'

                    // Översätt från sträng till ett heltal
                    // bruttolön = int.Parse(bruttolönSträng);
                    bool flaggaLön = int.TryParse(bruttolönSträng, out bruttolön);  // ger flaggaLön = false, bruttolön = 0

                    // Varna användaren om hen matar in något annat än ett heltal
                    if (flaggaLön == false)
                    {
                        Console.WriteLine("Vg mata in ett heltal!");
                    }
                    else if (bruttolön <= 0) // Om bruttolön <= 0 skriv ut felmeddelande
                    {
                        Console.WriteLine("Bruttolön måste vara > 0 kr!");
                    }
                }

                // Därefter räknas Marginalskatten
                int marginalskatt = 0;
                if (bruttolön < 10000)
                {
                    marginalskatt = 8;
                }
                else if (bruttolön < 145000)
                {
                    marginalskatt = 22;
                }
                else if (bruttolön < 515000)
                {
                    marginalskatt = 33;
                }
                else
                {
                    marginalskatt = 53;
                }

                // Sen räknas nettolön ut:
                // nettolön = bruttolön * (100 - marginalskatt) / 100
                int nettolön = bruttolön * (100 - marginalskatt) / 100;

                // Nettolönen presenteras för användaren
                Console.WriteLine($"Din nettolön blir {nettolön} kr." +
                                  $"Uträkning baserad på bruttolön {bruttolön} kr och marginalskatten {marginalskatt}%.");

                // Avslutningsvis frågar programmet om användaren vill göra en ny beräkning. 
                Console.Write("Vill du göra en ny beräkning? (j/n) ");
                igen = Console.ReadLine();

                // Acceptera svaret även om användaren skriver med versaler
                igen = igen.ToLower();
            }
        }
    }
}
