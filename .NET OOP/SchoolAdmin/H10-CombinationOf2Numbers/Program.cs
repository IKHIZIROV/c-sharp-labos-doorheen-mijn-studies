using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace H10_CombinationOf2Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassesAndObjects pair = new ClassesAndObjects();
            pair.Number1 = 12;
            pair.Number2 = 34;
            Console.WriteLine("Paar:" + pair.Number1 + ", " + pair.Number2);
            Console.WriteLine("Som = " + pair.Sum());
            Console.WriteLine("Verschil = " + pair.Difference());
            Console.WriteLine("Product = " + pair.Product());
            Console.WriteLine("Quotient = " + pair.Quotient());
        }
    }
}
