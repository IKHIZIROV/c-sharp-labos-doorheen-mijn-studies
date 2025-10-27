namespace opgave1pp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elNamen = { "Hydrogen", "Helium", "Lithium", "Beryllium", "Boron", "Carbon", "Nitrogen", "Oxygen", "Fluorine", "Neon", "Sodium", "Magnesium", "Aluminum", "Silicon", "Phosphorus", "Sulfur", "Chlorine", "Argon", "Potassium", "Calcium", "Scandium", "Titanium", "Vanadium", "Chromium", "Manganese", "Iron", "Cobalt", "Nickel", "Copper", "Zinc", "Gallium", "Germanium", "Arsenic", "Selenium", "Bromine", "Krypton", "Rubidium", "Strontium", "Yttrium", "Zirconium", "Niobium", "Molybdenum", "Technetium", "Ruthenium", "Rhodium", "Palladium", "Silver", "Cadmium", "Indium", "Tin", "Antimony", "Tellurium", "Iodine", "Xenon", "Cesium", "Barium", "Lanthanum", "Cerium", "Praseodymium", "Neodymium", "Promethium", "Samarium", "Europium", "Gadolinium", "Terbium", "Dysprosium", "Holmium", "Erbium", "Thulium", "Ytterbium", "Lutetium", "Hafnium", "Tantalum", "Tungsten", "Rhenium", "Osmium", "Iridium", "Platinum", "Gold", "Mercury", "Thallium", "Lead", "Bismuth", "Polonium", "Astatine", "Radon", "Francium", "Radium", "Actinium", "Thorium", "Protactinium", "Uranium", "Neptunium", "Plutonium", "Americium", "Curium", "Berkelium", "Californium", "Einsteinium", "Fermium", "Mendelevium", "Nobelium", "Lawrencium", "Rutherfordium", "Dubnium", "Seaborgium", "Bohrium", "Hassium", "Meitnerium", "Darmstadtium", "Roentgenium", "Copernicium", "Nihonium", "Flerovium", "Moscovium", "Livermorium", "Tennessine", "Oganesson" };
            string[] elSymbool = { "H", "He", "Li", "Be", "B", "C", "N", "O", "F", "Ne", "Na", "Mg", "Al", "Si", "P", "S", "Cl", "Ar", "K", "Ca", "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Ni", "Cu", "Zn", "Ga", "Ge", "As", "Se", "Br", "Kr", "Rb", "Sr", "Y", "Zr", "Nb", "Mo", "Tc", "Ru", "Rh", "Pd", "Ag", "Cd", "In", "Sn", "Sb", "Te", "I", "Xe", "Cs", "Ba", "La", "Ce", "Pr", "Nd", "Pm", "Sm", "Eu", "Gd", "Tb", "Dy", "Ho", "Er", "Tm", "Yb", "Lu", "Hf", "Ta", "W", "Re", "Os", "Ir", "Pt", "Au", "Hg", "Tl", "Pb", "Bi", "Po", "At", "Rn", "Fr", "Ra", "Ac", "Th", "Pa", "U", "Np", "Pu", "Am", "Cm", "Bk", "Cf", "Es", "Fm", "Md", "No", "Lr", "Rf", "Db", "Sg", "Bh", "Hs", "Mt", "Ds", "Rg", "Cn", "Nh", "Fl", "Mc", "Lv", "Ts", "Og" };

            Console.WriteLine("Hoeveel vragen moeten er in ronde 1 gevraagd worden?");
            int aantalVragen = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();

            for (int i = 0; i < aantalVragen; i++)
            {
                StelVraag(elNamen, elSymbool, VraagSoort.ZoekSymbool);
            }

            Console.WriteLine($"Uw score van ronde 1: ");

            int scoreTweedeRonde = 0;
            SuddenDeathRonde(elNamen, elSymbool);

            int scoreTotaal = scoreTweedeRonde;
            Console.WriteLine($"Je totaalscore van de 2 rondes is {scoreTotaal}");
        }

        enum VraagSoort {ZoekSymbool, ZoekAtoomNummer, ZoekNaam}

        static int StelVraag(string[] namen, string[] symbolen, VraagSoort soortVraag)
        {
            Random r = new Random();
            int score = 0;
            if (soortVraag == VraagSoort.ZoekSymbool)
            {
                int nummer = r.Next(0, namen.Length);
                Console.WriteLine($"Wat is het symbool van {namen[nummer]} (atoomnummer: {nummer+1})?");
                if (Console.ReadLine() == symbolen[nummer])
                    return score++;
                else
                {
                    Console.WriteLine($"Het juiste antwoord was {symbolen[nummer]}");
                    return 0;
                }
            }
            else if (soortVraag == VraagSoort.ZoekAtoomNummer)
            {
                int nummer = r.Next(0, namen.Length);
                Console.WriteLine($"Wat is het atoomnummer van {namen[nummer]}?");
                if (Convert.ToInt32(Console.ReadLine()) == nummer + 1)
                    return score++;
                else
                {
                    Console.WriteLine($"Het juiste antwoord was {nummer+1}");
                    return 0;
                }
            }
            else if (soortVraag == VraagSoort.ZoekNaam)
            {
                int nummer = r.Next(0, namen.Length);
                Console.WriteLine($"Wat is het element {symbolen[nummer]}, met atoomnummer {nummer+1}");
                if (Console.ReadLine() == namen[nummer])
                    return score++;
                else
                {
                    Console.WriteLine($"Het juiste antwoord was {namen[nummer]}");
                    return 0;
                }
            }
        }

        static int SuddenDeathRonde(string[] namen, string[] symbolen)
        {
            int scoreTweedeRonde = StelVraag(namen, symbolen, VraagSoort.ZoekSymbool);

        }
    }
}