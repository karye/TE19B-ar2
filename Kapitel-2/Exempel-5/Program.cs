using System;

namespace Exempel_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn = "Karim";
            Console.WriteLine("Mitt namn är " + namn);

            // Mha variabelsubtitution
            Console.WriteLine($"Mitt namn är {namn}.");

            string svar = $"Mitt förnamn är {namn}.";
            Console.WriteLine(svar);
            
        }
    }
}
