using System;

namespace _4_Mahukalkulaator

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast mahukalkulaatorisse!");
            Console.Write("Kas soovite arvutada kuubi, risttahuka või silindri ruumala? (kuup/risttahukas/silinder): ");
            string? valik = Console.ReadLine()?.ToLower();

            double ruumala = 0;

            if (valik == "kuup")
            {
                Console.Write("Sisesta kuubi külje pikkus: ");
                double kylg = Convert.ToDouble(Console.ReadLine());
                ruumala = kylg * kylg * kylg;
            }
            else if (valik == "risttahukas")
            {
                Console.Write("Sisesta risttahuka pikkus: ");
                double pikkus = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sisesta risttahuka laius: ");
                double laius = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sisesta risttahuka kõrgus: ");
                double korgus = Convert.ToDouble(Console.ReadLine());
                ruumala = pikkus * laius * korgus;
            }
            else if (valik == "silinder")
            {
                Console.Write("Sisesta silindri põhjaga raadius: ");
                double raadius = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sisesta silindri kõrgus: ");
                double korgus = Convert.ToDouble(Console.ReadLine());
                Console.Write("Kas silindril on kaas? Sisesta kaane paksus (0 kui puudub): ");
                double kaanepaksus = Convert.ToDouble(Console.ReadLine());
                double sisuKorgus = korgus - kaanepaksus;
                if (sisuKorgus < 0) sisuKorgus = 0;
                ruumala = Math.PI * raadius * raadius * sisuKorgus;
            }

            Console.WriteLine($"Teie valitud objekti ruumala on: {ruumala:F2}");
        }
    }
}