namespace _10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lucario

            Pokémon Lucario = new Pokémon();
            
            Lucario.HP_Base = 70;
            Lucario.Attack_Base = 110;
            Lucario.Defence_Base = 70;
            Lucario.SpecialAttack_Base = 115;
            Lucario.SpecialDefence_Base = 70;
            Lucario.Speed_Base = 90;

            Lucario.Naam = "Lucario";
            Lucario.Type = "fighting";
            Lucario.Nummer = 448;


            // Tyranitar

            Pokémon Tyranitar = new Pokémon();

            Tyranitar.HP_Base = 100;
            Tyranitar.Attack_Base = 134;
            Tyranitar.Defence_Base = 110;
            Tyranitar.SpecialAttack_Base = 95;
            Tyranitar.SpecialDefence_Base = 100;
            Tyranitar.Speed_Base = 61;

            Tyranitar.Naam = "Tyranitar";
            Tyranitar.Type = "Dark";
            Tyranitar.Nummer = 448;


            // 6 base stats vragen aan gebruiker

            Pokémon PokémonA = new Pokémon();
            Console.WriteLine("Geef de base stats van je pokémon:");

            Console.WriteLine("HP:");
            PokémonA.HP_Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Attack:");
            PokémonA.Attack_Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Defence:");
            PokémonA.Defence_Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SpecialAttack:");
            PokémonA.SpecialAttack_Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SpecialDefence:");
            PokémonA.SpecialDefence_Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Speed:");
            PokémonA.Speed_Base = Convert.ToInt32(Console.ReadLine());

            PokémonA.ShowInfo();


            // Aan gebruiker vragen tot welke level de pokémon gelevelled moet worden

            Console.WriteLine("Tot welke level moet je pokémon gelevelled worden?");
            int levels = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < levels; i++)
            {
                PokémonA.VerhoogLevel();
            }

            Console.WriteLine(PokémonA.Level);


            PokémonA.ShowInfo();
        }
    }
}