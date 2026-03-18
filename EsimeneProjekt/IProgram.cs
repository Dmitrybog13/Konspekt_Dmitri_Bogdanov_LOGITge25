namespace EsimeneProjekt
{
    internal interface IProgram
    {
        static abstract int ArvutaKokku(int[] arvud);
        static abstract void UusMeetod();
        string KeskmineTase(float veetase = 1.5F);
        void MillineTekst(int vanus, int? pikkus);
    }
}