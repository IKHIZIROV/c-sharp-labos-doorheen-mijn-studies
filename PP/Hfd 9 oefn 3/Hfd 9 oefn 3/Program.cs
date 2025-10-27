namespace Hfd_9_oefn_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BelastingsControleur bas = new BelastingsControleur();
            BelastingsControleur jos = new BelastingsControleur();

            Console.WriteLine(jos.berekenBelastingen(3000));

            Console.WriteLine(bas.berekenBelastingen(2000));
        }
    }
}