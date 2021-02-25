using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi skriver text vertikalt:");

            // Den första texten
            SkrivVertikalt("Metoder!!!");

            // Den andra texten
            SkrivVertikalt("Metoder är kul");

            // Den tredje texten
            SkrivVertikalt("Mycket användbart i min programmering");
        }

        // En metod för att skriva text vertikalt
        // Parameter: string text1
        static void SkrivVertikalt(string text1) {
            for (int i = 0; i < text1.Length; i++)
            {
                Console.WriteLine(text1[i]);
            }
        }
    }
}
