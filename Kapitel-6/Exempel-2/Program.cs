using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string svar = "";
            while (svar != "3")
            {
                VisaMeny();
                svar = Console.ReadLine();

                switch (svar)
                {
                    case "1":
                    SkrivUtVertikalt();
                    break;

                    case "2":
                    SkrivUtOmvänt();
                    break;

                    case "3":
                    //
                    break;
                    default:
                }
            }
        }

        static void VisaMeny() {
            Console.WriteLine("Välj ett alterniv");
            Console.WriteLine("1. Skriv ut texten vertikalt");
            Console.WriteLine("2. Skriv ut texten omvänt");
            Console.WriteLine("3. Avsluta");
        }

        static void SkrivUtVertikalt() {

        }

        static void SkrivUtOmvänt() {
            
        }
    }
}
