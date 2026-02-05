namespace DOWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
			/* Do-while ülesanded*/

			// 1. "arvuta kuni summani"
			// tee muutuja "täisarv" mille sees on täisarv 0
			// kirjuta do while tsükkel
			// tsükli tegevusena lahuta muutujast "täisarv" maha 2
			// ja kuva muutuja "täisarv" välja
			// -> do while tsükli tingimuseks kirjuta kontroll, mis kontrollib kas muutujas "täisarv" on arv miinuses rohkem kui -31
			// peale tsüklit kuva sõnum "tsükkel lõppes"

			// 2. "pikenda sõnumit"
			// tee muutuja "sõnum" mille sees on tühi string, nt ""
			// kirjuta do while tsükkel
			// tsükli tegevusena küsi kasutajalt sõnumile lisa "palun lisa järgmine sõnumi osa
			// lisa muutujasse "sõnum" kasutaja poolt tehtud sisestus
			// kuva muutuja "sõnum" välja
			// -> do while tsükli tingimuseks kirjuta kontroll, mis kontrollib muutuja "sõnum" pikkust .Length abil, kui sõnum on pikem kui 140 tähte, siis tsükkel lõppeb
			// peale tsüklit kuva sõnum "see sõnum enam twitterisse ei mahuks, kirjuta vähem fam"


			//string login;
			//string parool;
			//Console.WriteLine("Palun sisesta oma login");
			//login = Console.ReadLine();
			//Console.WriteLine("Ja parool");
			//parool = Console.ReadLine();
			//if (login == "Dmitry" && parool == "12345")
			//{
			//	Console.WriteLine("Welkomen, " + login);
			//}
			//else
			//{
			//	Console.WriteLine("Wrong password or username IDIOT");
			//}


			Console.WriteLine("Palun sisesta esimene arv");
			float arv1 = 0.0f;
			arv1 = float.Parse(Console.ReadLine());


			Console.WriteLine("Palun sisesta teine arv");
			float arv2 = 0.0f;
			arv2 = float.Parse(Console.ReadLine());


			Console.WriteLine("Mis tüüpi tehet sa teha tahad? (valik: + - * / ^ V)");
			string tehteTüüp = "";
			tehteTüüp = Console.ReadLine();


			double tulemus = 0.0d;
			bool tehtud = true;
			if (tehteTüüp == "+")
			{
				tulemus = arv1 + arv2;
			}

			else if (tehteTüüp == "-")

			{

				tulemus = arv1 - arv2;

			}

			else if (tehteTüüp == "*")

			{

				tulemus = arv1 * arv2;

			}

			else if (tehteTüüp == "/")

			{

				tulemus = arv1 / arv2;

			}

			else if (tehteTüüp == "^")

			{

				tulemus = Math.Pow(arv1, arv2);

			}

			else if (tehteTüüp == "V")

			{

				tulemus = Math.Pow(arv1, (1 / arv2));

			}

			else

			{

				Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");

				tehtud = false;

			}

			if (tehtud)

			{

				Console.WriteLine($"Tehte tulemus on: {arv1} {tehteTüüp} {arv2} = {tulemus}");

			}



		}
    }
}
