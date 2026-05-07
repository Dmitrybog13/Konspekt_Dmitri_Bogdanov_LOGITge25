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


            Console.WriteLine("\nPress Enter (do you know how enter looks on ur keyboard?)");
            Console.ReadLine();


            // HARJUTUS 2
            Console.WriteLine("HARJUTUS 2");

            int aasta = 0;

            while (aasta < 1000 || aasta > 2026)
            {
                Console.Write("Sisesta aasta: ");
                aasta = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("\nPress Enter again (if you know u know)");
            Console.ReadLine();


            // HARJUTUS 3
            Console.WriteLine("HARJUTUS 3");

            List<string> kingitus = new List<string>()
            {
                "Arvuti (Core 2 duo, 2GB RAM, 8800GT)",
                "PS 5 PRO MAX ULTRA",
                "Robux Gift Card 12700RB",
                "ChatGPT Subscription",
                "NO SCOPE 360",
            };

            Console.WriteLine("kingitus nimekiri:");

            for (int i = 0; i < kingitus.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {kingitus[i]}");
            }


            Console.WriteLine("\nPress F to pay respect");
            Console.ReadLine();


            // HARJUTUS 4
            Console.WriteLine("HARJUTUS 4");

            List<int> arvud = new List<int>() { 8, 16, 32, 67, 128 };

            int tulemus = 1;

            foreach (int arv in arvud)
            {
                tulemus *= arv;
                Console.WriteLine($"Praegune korrutis: {tulemus}");
            }
        }
    }
}
