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


            /*int KasutajaVanus = 0;
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


            /*
             näiteprogramm 3:

            klient tahab et programm teeks:
            - küsib kasutajalt tema kasutajaNime
            - küsib kasutajalt tema parooli
            - logib kasutaja sisse kui mõlemad on õiged
            */
            // hint: mida teeb &&?

            /* siia käib vooskeemi järgi kirjutatud kood näidisülesanne 3 kohta */

            /*int mingiarv = 4;

            mingiarv = mingiarv + 15; //
            mingiarv = mingiarv * 15; // 
            mingiarv = mingiarv - 15; // 
            mingiarv = mingiarv / 15; //


            mingiarv += 15;
            mingiarv -= 15;
            mingiarv *= 15;
            mingiarv /= 15;

            /*naiteulesanne 4 */
            /* Console.WriteLine("Palun sisesta oma vanus"); 
            // esitame kasutajale küsimuse, console writeline kuvamisfunktsiooniga
            int kasutajavanus = int.Parse(Console.ReadLine()); 
            // tekitame muutuja kasutajavanus ning omistame sinna käsurealt int.Parser abiga täisarvu
            Console.WriteLine("Palun sisesta oma vanavanema vanus");
            // esitame kasutajale küsimuse, console writeline kuvamisfunktsiooniga
            int kasutajaVanavanemaVanus = int.Parse(Console.ReadLine());
            // tekitame muutuja kasutajavanus ning omistame sinna käsurealt int.Parser abiga täisarvu
            int vanusteVahe = kasutajaVanavanemaVanus - kasutajavanus;
            // tekitame uue täisarvu muutuja kuhu omistame avaldise kasutajavanavanemavanus - kasutajavanus tulemuse
            Console.WriteLine(kasutajaVanavanemaVanus - kasutajavanus);
            // Saab ka otse kuvada, ilma muutujata
            Console.WriteLine("Kui palju sa vanem olid?");
            // esitame kasutajale küsimuse, console writeline kuvamisfunktsiooniga
            kasutajavanus += int.Parse(Console.ReadLine());
            // kasutame omistusoperaatorit, et lisada muutujale kasutaja poolt esitatud täisarvu
            Console.WriteLine("vanuste vahe on nüüd: " + (kasutajaVanavanemaVanus - kasutajavanus));
            // kuvame uuesti vanuste vahe koos tekstiga

            /*
            Üleval harjutuses
             
             
             
             
             All teooria
             */




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

            /* -= O M I S T U S O P E R A A T O R I D =-  */

            /* // =   -> üksik vürdusmärk omistab muutja sisse väärtuse, mida adresseritakse muutuja enda nimega
            int muutuja = 1;
            // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva väärtuse
            muutuja += 2;
            // += -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujas olevast väärtusest võrdusmärki teisel pool oleva väärtuse
            muutuja -= 1;
            // += -> võrdusmärk mille ees on korrutusmärk, automaatselt korrutab muutuja sisu võrdusmärgi teisel pool oleva väärtuse kordi
            muutuja *= 3;
            // += -> võrdusmärk mille ees on jagamismärk, automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva väärtuse osadeks
            muutuja /= 4;
            // %= -> võrdusmärk mille ees on modulus, automaatselt jätab muutujasse jäägi
            muutuja %= 2;

            // ++ -> on kiirtehe, mis muutujale liidab ainult ühe juurde.
            muutuja++;
            // -- -> on kiirtehe, mis muutujast lahutab ainult ühe maha.
            muutuja--; */

            /* näiteülesanne 5 */
            
            Console.WriteLine("Kui kaugele oli su viimane kuulitõuge (M)?");
            float kaugus = float.Parse(Console.ReadLine());
            if (kaugus <= 1.00)
            {
                Console.WriteLine("Sa suudad kindlasti rohkem, cmon bruh");
            }
            else if (kaugus <= 2.00)
            {
                Console.WriteLine("noh tuleb juba, jõuad veel!");
            }
            else if (kaugus <= 3.00)
            {
                Console.WriteLine("TUBLI kolm meetrit umbes, peaaegu, vist... not sure");
            }
            else
            {
                Console.WriteLine("Ossaraks, seda on varsti orbiidilt näha");
            }
        }
    }
}
