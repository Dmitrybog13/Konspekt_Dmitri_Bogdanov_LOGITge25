using System.Diagnostics.Tracing;

namespace Dmitry_s_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int palk = 2345;
            //int kulud = 1122;

            //Console.WriteLine("Kas see kuu kulusid või väljaminekuid oli? (jah/ei)");
            //string kasutajaVastus = "";
            //kasutajaVastus = Console.ReadLine();
            //if (kasutajaVastus == "jah")
            //{
            //    Console.WriteLine("sisesta kõik kulutused ühe arvuna");
            //    kulud = int.Parse(Console.ReadLine());
            //}   

            //int kontojääk = palk - kulud;
            //Console.WriteLine(kontojääk + " puulehte on alles."); // print(kontojääk + " puulehte on alles")
            //Console.WriteLine("Palun sisesta oma hästi tehtud töö boonus: ");
            //int boonus = int.Parse(Console.ReadLine()); // boonus = int(input("Palun sisesta oma hästi tehtud töö boonus: "))
            //kontojääk = kontojääk + boonus; // same python
            //Console.WriteLine("Sinu lõppväljavõte on: " + kontojääk + " puulehte");



            /* näiteprogramm 2 */
            /*
             * programm küsib kasutajalt tema vanust
             * kui ta on noorem kui 18 öeldakse kasutajale "alaealisi sisse ei lasta"
             * kui on vanem kui 18, pakutakse mojitot
             * 
             */


            int KasutajaVanus = 0;
            Console.WriteLine("kui vana sa oled?");
            KasutajaVanus = int.Parse(Console.ReadLine());
            if (KasutajaVanus > 18)
            {
                Console.WriteLine("Tere, siin on sinu mojito 🍋‍");
            }
            else
            {
                Console.WriteLine("Alaealisi sisse ei lasta, mine vembutembumaale. 😊");
            }






            //        string tekst = "mingisugune inimloetav tekstide"; //tekst
            //        char täht = 'A';
            //        int arv = 1; //täisarv
            //        float kemakohagaarv = 1.5f; //32bit
            //        double suuremkomakohagaarv = 1.5d; //64bit
            //        decimal kümnendsüsteemiskomakohagaarv = 1.5M;
            //        var x = 123; //ümbmäärase andmetüübiga ajutine muutuja
            //        var y = "ABC";
            //        bool jahvõiei = false;`//kas true või false.

            //        /**/
            //        string string ´= "abc" //is bäd
            //        string sõne = "abc" //is gud

        }
    }
}
