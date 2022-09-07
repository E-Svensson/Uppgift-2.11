using System;

namespace Uppgift_211
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elin hoppar längre än Alma.");
            Console.Write("Bestäm hur långt Elin hoppade i meter: "); string Elin_Längd_Text = Console.ReadLine();
            Console.Write("Bestäm nu hur långt Alma hoppade i meter: "); string Alma_Längd_Text = Console.ReadLine();

            float Elin_Längd_Tal = float.Parse(Elin_Längd_Text);
            float Alma_Längd_Tal = float.Parse(Alma_Längd_Text);

            float Skillnad = Elin_Längd_Tal - Alma_Längd_Tal;

            Console.WriteLine("Elin hoppade då " + Skillnad + " meter längre än Alma.");
        }
    }
}
