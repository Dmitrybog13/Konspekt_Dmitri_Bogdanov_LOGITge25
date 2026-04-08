using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        Console.WriteLine("Tere tulemast investeerimissimulaatorisse!");
        Console.Write("Sisesta investeeritav summa: ");
        double summa = double.Parse(Console.ReadLine());

        Console.Write("Mitu päeva soovid turul olla? ");
        int päevad = int.Parse(Console.ReadLine());

        double portfell = summa;

        for (int päev = 1; päev <= päevad; päev++)
        {
            Console.WriteLine($"\nPäev {päev}:");
            string[] firmad = { "Tesla", "TransferWise", "Macro$lop" };
            string valitudFirma = firmad[rnd.Next(firmad.Length)];
            double kordaja = 0;

            switch (valitudFirma)
            {
                case "Tesla":
                    kordaja = -1.15; // fikseeritud kordaja
                    break;
                case "TransferWise":
                    // juhuslik arv 1–100, jagada 1000-ga ja liita 1
                    kordaja = 1 + rnd.Next(1, 101) / 1000.0;
                    break;
                case "Macro$lop":
                    // sama kui TransferWise, aga alati negatiivne
                    kordaja = -(1 + rnd.Next(1, 101) / 1000.0);
                    break;
            }

            double päevakasv = portfell * kordaja;
            portfell += päevakasv;

            Console.WriteLine($"Firma: {valitudFirma}, Hetkekordaja: {kordaja:F3}, Portfelli väärtus: {portfell:F2}");

            if (portfell <= 0)
            {
                Console.WriteLine("Portfell on nullis või negatiivne. Sa oled pankrotis.");
                break;
            }

            Console.Write("Kas soovid jätkata investeerimist? (jah/ei): ");
            string jätka = Console.ReadLine().ToLower();
            if (jätka != "jah")
            {
                break;
            }
        }

        Console.WriteLine($"\nLõppportfell: {portfell:F2}");
    }
}