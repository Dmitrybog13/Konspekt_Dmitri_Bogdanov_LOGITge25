
namespace _4_Mahukalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kirjuta programm mis
            //küsib kasutajalt kas ta tahab arvutada oma kasti mahtu, või õlivaadi mahtu
            //sisendite küsimiseks on oma meetod, mis ei lase programmil edasi liikuda, kuni vastus ei ole tühi, ega üks võimalikest valikutest.
            //selle tegemiseks annate meetodile parameetrina valikud listis kaasa ja .Contains abil saate kontrollida kas ta on olemas või mitte
            //kui programm teab kumba ta arvutab toimuvad järgmised tegevused
            //  kasti puhul, küsitakse kas kast on kuubik või risttahukas.
            //    - kuubiku puhul küsitakse küljepikkus, antakse parameetrina meetodile KuubiRuumala() kaasa,
            //      ning kuubiruumala tagastab double tüüpi andmena muutujasse tehte tulemuse. valem otsi internetist.
            //    - risttahuka puhul lühima ja pikima külje pikkust ning kõrgust. samamoodi arvutab parameetrite abil 
            //      meetod RisttahukaRuumala() tulemuse double andmena ja tagastab selle muutujasse.
            //  Tünni puhul, küsitakse kas ta tünn on kaanega või kaaneta.
            //    - Kui tal on kaas olemas, siis küsi selle paksust, kui ei ole, määra paksuseks ise 0
            //      Küsi kasutajalt ka tünni põhja läbimõõtu ja kõrgust ning arvuta SilindriRuumala()
            //      meetodiga kus parameetrid ka kaasas double tulemus mille tagastad muutujasse
            //      NB! kaane paksuse arvutad kõrgusest maha, sest kaas võtab õlitünni sees mingi ruumala enda poolt ära.
            //Kuva kasutajale tema ruumala tulemus peaprogrammis, mitte arvutatavates meetodites.
            string[] valikud = new string[] { "Arvutada kasti mahtu", "Arvutada õlivaadi mahtu" };
            Console.WriteLine("Mida sa teha soovid? Palun vali arvuga: ");
            int valikuteArv = valikud.Length;
            for (int i = 0; i < valikud.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + valikud[i]);
            }
            int kasutajaValik = Valik(new List<int> { 1, 2 });
            if (kasutajaValik == 1)
            {
                Console.WriteLine("Kas kast on kuubik või risttahukas?: ");
                if (kasutajaValik == 1)
                {

                }
            }

           























        }

        private static int Valik(List<int> list)
        {int valik;
            do
            {
                Console.WriteLine("Sisesta oma valik: ");
                valik = int.Parse(Console.ReadLine());
            } while (!list.Contains(valik));
            return valik;
            throw new NotImplementedException();
        }
    }
}
