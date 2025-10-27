namespace Hfds_9_oefn_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer mijnEerstePC = new Computer();
            Computer gamePc = new Computer();
            gamePc.ZetAan();

            mijnEerstePC.ZetAan();

            gamePc.ZetAan();
        }
    }
}