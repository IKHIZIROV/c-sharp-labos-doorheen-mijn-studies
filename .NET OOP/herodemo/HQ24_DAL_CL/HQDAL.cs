namespace HQ24_DAL_CL
{
    public class HQDAL
    {
        /// <summary>
        /// Geeft een csv-tekst terug die alle eigneschappen van ieder type monster bevat
        /// </summary>
        /// <returns>csv met header</returns>
        public static string GetMonsterStats()
        {
            return "Type;Aanval;Verdediging;Lichaam;Intelligentie;Beweging\r\n"+
                "Goblin;2;1;1;1;10\r\n"+
                "Orc;3;2;1;2;8\r\n"+
                "Fimir; 3;3;1;3;6\r\n"+
                "Skeleton;2;2;1;0;6\r\n"+
                "Zombie;2;3;1;0;4\r\n"+
                "Mummy;3;4;1;0;4\r\n"+
                "Chaos Warrior;3;4;1;3;6\r\n"+
                "Gargoyle;4;4;1;4;6\r\n"+
                "Elven Archer;4;2;3;2;6\r\n"+
                "Elven Warrior;4;3;3;2;6\r\n" +
                "Giant Wolf;6;3;5;1;9\r\n" +
                "Orge;6;4;10;2;4\r\n" +
                "Ice Gremlin;2;3;3;3;10\r\n" +
                "Polar Warbear;4;3;6;2;6\r\n" +
                "Yeti;3;3;5;2;8\r\n" +
                "Crossbowman;3;3;2;2;6\r\n" +
                "Halberdier;3;3;2;2;6\r\n" +
                "Scout;2;3;2;2;9\r\n" +
                "Swordsman;4;5;2;2;5\r\n" +
                "Crossbowman;2;3;1;2;6\r\n" +
                "Halberdier;3;3;1;2;6\r\n" +
                "Scout;2;3;1;2;9\r\n" +
                "Swordsman;4;5;1;2;4\r\n" +
                "Doomguard;4;5;1;3;6";
        }
    }
}