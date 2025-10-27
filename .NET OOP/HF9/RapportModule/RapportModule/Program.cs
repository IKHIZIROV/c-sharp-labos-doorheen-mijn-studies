namespace RapportModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rapport mijnpunten = new Rapport();
            mijnpunten.Percentage = 65;
            mijnpunten.PrintGraad();
        }
    }
}