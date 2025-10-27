namespace BankManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rekening rekening1 = new Rekening();
            rekening1.Staat = RekeningStaat.Geldig;
            Rekening rekening2 = new Rekening();
            rekening2.Staat = RekeningStaat.Geldig;

            rekening2.NaamKlant = "Ryan Gosling";
            rekening2.RekeningNummer = "BE81 4587 6549 5210";
            rekening2.ToonInfo();

            rekening1.StortGeld(rekening2.HaalGeldAf(300));

            rekening2.ToonInfo();
        }
    }
}