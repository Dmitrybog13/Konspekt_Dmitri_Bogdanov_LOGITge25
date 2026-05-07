using System;
using System.Collections.Generic;
using System.Timers;

namespace Tsyklitoo
{
    internal class Start
    {
        static void Main(string[] args)
        {
            // HARJUTUS 1
            Console.WriteLine("HARJUTUS 1");

            int vanus;

            do
            {
                Console.Write("Sisesta oma vanus: ");
                vanus = Convert.ToInt32(Console.ReadLine());

            } while (vanus >= 0);


            Console.WriteLine("\nVajuta Enter järgmise osa jaoks...");
            Console.ReadLine();


            // HARJUTUS 2
            Console.WriteLine("HARJUTUS 2");

            int aasta = 0;

            while (aasta < 1000 || aasta > 2025)
            {
                Console.Write("Sisesta aasta: ");
                aasta = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("\nVajuta Enter järgmise osa jaoks...");
            Console.ReadLine();


            // HARJUTUS 3
            Console.WriteLine("HARJUTUS 3");

            List<string> puuviljad = new List<string>()
            {
                "Banaan",
                "Pirn",
                "Kiivi",
                "Apelsin",
                "Mango"
            };

            Console.WriteLine("Puuviljade nimekiri:");

            for (int i = 0; i < puuviljad.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {puuviljad[i]}");
            }


            Console.WriteLine("\nVajuta Enter viimase ülesande jaoks...");
            Console.ReadLine();


            // HARJUTUS 4
            Console.WriteLine("HARJUTUS 4");

            List<int> arvud = new List<int>() { 2, 4, 6, 8 };

            int tulemus = 1;

            foreach (int arv in arvud)
            {
                tulemus *= arv;
                Console.WriteLine($"Praegune korrutis: {tulemus}");
            }
        }
    }
}
