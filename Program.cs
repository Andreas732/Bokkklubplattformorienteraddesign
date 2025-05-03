using System;

namespace Bokklubbplattform
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Innehåll innehåll1 = InnehållFabrik.SkapaInnehåll("Recension");
                innehåll1.Visa();

                Innehåll innehåll2 = InnehållFabrik.SkapaInnehåll("Diskussion");
                innehåll2.Visa();

                Innehåll innehåll3 = InnehållFabrik.SkapaInnehåll("Event");
                innehåll3.Visa();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fel: {ex.Message}");
            }

            Console.WriteLine("Tryck valfri tangent för att avsluta...");
            Console.ReadKey();
        }
    }
}


