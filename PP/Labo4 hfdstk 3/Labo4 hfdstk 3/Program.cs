namespace Labo4_hfdstk_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool is64bit = Environment.Is64BitOperatingSystem;
            string pcname = Environment.MachineName;
            int proccount = Environment.ProcessorCount;
            string username = Environment.UserName;
            long memory = Environment.WorkingSet; //zal ongeveer 10 Mb teruggeven.

            Console.WriteLine($"Je computernaam is {pcname}");
            Console.WriteLine($"en dit programma gebruikt {memory} byte geheugen");
            Console.WriteLine($"En je usernaam is {Environment.UserName}");


        }
    }
}