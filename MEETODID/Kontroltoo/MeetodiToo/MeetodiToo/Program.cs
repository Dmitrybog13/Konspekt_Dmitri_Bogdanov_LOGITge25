using System;
using System.Linq;

namespace MeetodiToo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Tervitus
            KuvaTervitus();

            // 2. Arvutus: massiivi jagamine (loogika on meetodi sees)
            double[] arvud = { 500000.1, 100.567, 12.345, 6.66, 0.00033 };
            double tulemus = ArvutaMassiiviJagatis(arvud);
            Console.WriteLine($"Lõpptulemus on: {tulemus}");
            Console.WriteLine("Arvutused tehtud, liigume edasi.");

            // 3. Töötlus: 'a' tähtede lugemine kasutades .Count()
            Console.WriteLine("\nSisesta oma perekonnanimi:");
            string nimi = Console.ReadLine() ?? "";
            int aHulk = LoendaATahed(nimi);
            Console.WriteLine($"Sinu nimi sisaldab 'a' tähte {aHulk} korda.");

            // 4. Tuvastus: distantsi analüüs
            Console.WriteLine("\nMitu kilomeetrit sa täna kõndisid?");
            if (int.TryParse(Console.ReadLine(), out int distants))
            {
                Console.WriteLine(AnalüüsiTeekonda(distants));
            }
        }

        

        private static void KuvaTervitus()
        {
            Console.WriteLine("Tere! Siin on kontrolltöö parandus.");
        }

       
        private static double ArvutaMassiiviJagatis(double[] massiiv)
        {
            if (massiiv.Length == 0) return 0;

            double vahetulemus = massiiv[0];
            for (int i = 1; i < massiiv.Length; i++)
            {
                vahetulemus /= massiiv[i];
            }
            return vahetulemus;
        }

        
        private static int LoendaATahed(string tekst)
        {
            return tekst.Count(sumbol => char.ToLower(sumbol) == 'a');
        }

        private static string AnalüüsiTeekonda(int km)
        {
            if (km < 0) return "Vigane sisend";
            if (km == 0) return "Paigalseisuga tervist ei hoia";
            if (km < 5) return "Tubli tulemus, kontorirotid tavaliselt nii palju ei liigu";
            if (km < 10) return "Pool linna kõnnib sellega maha";
            if (km < 15) return "Wow, see võtab üksjagu aega";
            return "Ära kiirusta!!! >_<";
        }
    }
}