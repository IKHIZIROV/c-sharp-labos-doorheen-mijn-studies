using ClassLibrary1;
using System;

namespace WeerstandsCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Kleur ring1, ring2, ring3;
                ring1 = VraagRingKleur(1);
                ring2 = VraagRingKleur(2);
                ring3 = VraagRingKleur(3);

                WeerstandsCalculator1 calculator = new WeerstandsCalculator1();
                double waarde = calculator.BerekenWeerstand(ring1, ring2, ring3);

                Console.WriteLine($"De waarde van deze weerstand bedraagt {waarde} ohm");
            }
        }

        /// <summary>
        /// Vraag de gebruiker om een kleurnaam in te geven voor een bepaalde ring
        /// </summary>
        /// <param name="nummer">het nummer van de ring</param>
        /// <returns></returns>
        public static Kleur VraagRingKleur(int nummer)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"Geef ring {nummer}");
                    string ring = Console.ReadLine();
                    Kleur resultaat = (Kleur)Enum.Parse(typeof(Kleur), ring);
                    return resultaat;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, deze kleur ken ik niet.");
                }
            }
        }

        /// <summary>
        /// Bereken de totale weerstandswaarde (in ohm) van de gegeven weerstand.
        /// </summary>
        /// <param name="ring1">kleur van ring 1</param>
        /// <param name="ring2">kleur van ring 2</param>
        /// <param name="ring3">kleur van ring 3</param>
        /// <returns></returns>
        
    }

}