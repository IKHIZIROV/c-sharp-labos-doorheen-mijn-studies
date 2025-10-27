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

                double waarde = BerekenWeerstand(ring1, ring2, ring3);

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
        public static double BerekenWeerstand(Kleur ring1, Kleur ring2, Kleur ring3)
        {
            int r1 = 0, r2 = 0, r3 = 0;

            switch (ring1)
            {
                case Kleur.Zwart:
                    r1 = 0;
                    break;
                case Kleur.Bruin:
                    r1 = 1;
                    break;
                case Kleur.Rood:
                    r1 = 2;
                    break;
                case Kleur.Oranje:
                    r1 = 3;
                    break;
                case Kleur.Geel:
                    r1 = 4;
                    break;
                case Kleur.Groen:
                    r1 = 5;
                    break;
                case Kleur.Blauw:
                    r1 = 6;
                    break;
                case Kleur.Paars:
                    r1 = 7;
                    break;
                case Kleur.Grijs:
                    r1 = 8;
                    break;
                case Kleur.Wit:
                    r1 = 9;
                    break;
                default:
                    break;
            }

            switch (ring2)
            {
                case Kleur.Zwart:
                    r2 = 0;
                    break;
                case Kleur.Bruin:
                    r2 = 1;
                    break;
                case Kleur.Rood:
                    r2 = 2;
                    break;
                case Kleur.Oranje:
                    r2 = 3;
                    break;
                case Kleur.Geel:
                    r2 = 4;
                    break;
                case Kleur.Groen:
                    r2 = 5;
                    break;
                case Kleur.Blauw:
                    r2 = 6;
                    break;
                case Kleur.Paars:
                    r2 = 7;
                    break;
                case Kleur.Grijs:
                    r2 = 8;
                    break;
                case Kleur.Wit:
                    r2 = 9;
                    break;
                default:
                    break;
            }

            switch (ring3)
            {
                case Kleur.Zwart:
                    r3 = 0;
                    break;
                case Kleur.Bruin:
                    r3 = 1;
                    break;
                case Kleur.Rood:
                    r3 = 2;
                    break;
                case Kleur.Oranje:
                    r3 = 3;
                    break;
                case Kleur.Geel:
                    r3 = 4;
                    break;
                case Kleur.Groen:
                    r3 = 5;
                    break;
                case Kleur.Blauw:
                    r3 = 6;
                    break;
                case Kleur.Paars:
                    r3 = 7;
                    break;
                case Kleur.Grijs:
                    r2 = -2;
                    break;
                default:
                    break;
            }

            double waarde = (r1 * 10 + r2) * Math.Pow(10, r3);
            return waarde;
        }
    }
    public enum Kleur
    {
        Zwart,
        Bruin,
        Rood,
        Oranje,
        Geel,
        Groen,
        Blauw,
        Paars,
        Grijs,
        Wit
    }
}