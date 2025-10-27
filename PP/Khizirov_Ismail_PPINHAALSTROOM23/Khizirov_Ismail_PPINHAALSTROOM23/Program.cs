using System.Net.Sockets;
using System.Threading.Tasks.Sources;

namespace Khizirov_Ismail_PPINHAALSTROOM23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Kies:");
            Console.WriteLine("1 of 2");
            int keuze = Int32.Parse(Console.ReadLine());

            if (keuze != 1 && keuze != 2)
            {
                Console.WriteLine();
                Console.WriteLine("Kies alleen uit:");
                Console.WriteLine("1 of 2");
                keuze = Int32.Parse(Console.ReadLine());
            }

            string[] nedArray = { "as", "I", "his", "that", "he", "was", "for", "on", "are", "with", "they", "be", "at", "one", "have", "this", "from", "by", "hot", "word", "but", "what", "some", "is", "it", "you", "or", "had", "the", "of", "to", "and", "a", "in", "we", "can", "out", "other", "were", "which", "do", "their", "time", "if", "will", "how", "said", "an", "each", "tell", "does", "set", "three", "want", "air", "well", "also", "play", "small", "end", "put", "home", "read", "hand", "port", "large", "spell", "add", "even", "land", "here", "must", "big", "high", "such", "follow", "act", "why", "ask", "men", "change", "went", "light", "kind", "off", "need", "house", "picture", "try", "us", "again", "animal", "point", "mother", "world", "near", "build", "self", "earth", "father", "any", "new", "work", "part", "take", "get", "place", "made", "live", "where", "after", "back", "little", "only", "round", "man", "year", "came", "show", "every", "good", "me", "give", "our", "under", "name", "very", "through", "just", "form", "sentence", "great", "think", "say", "help", "low", "line", "differ", "turn", "cause", "much", "mean", "before", "move", "right", "boy", "old", "too", "same", "she", "all", "there", "when", "up", "use", "your", "way", "about", "many", "then", "them", "write", "would", "like", "so", "these", "her", "long", "make", "thing", "see", "him", "two", "has", "look", "more", "day", "could", "go", "come", "did", "number", "sound", "no", "most", "people", "my", "over", "know", "water", "than", "call", "first", "who", "may", "down", "side", "been", "now", "find", "head", "stand", "own", "page", "should", "country", "found", "answer", "school", "grow", "study", "still", "learn", "plant", "cover", "food", "sun", "four", "between", "state", "keep", "eye", "never", "last", "let", "thought", "city", "tree", "cross", "farm", "hard", "start", "might", "story", "saw", "far", "sea", "draw", "left", "late", "run", "don’t", "while", "press", "close", "night", "real", "life", "few", "north" };
            string[] engArray = { "als", "I", "zijn", "dat", "hij", "was", "voor", "op", "zijn", "met", "ze", "zijn", "bij", "een", "hebben", "deze", "van", "door", "heet", "woord", "maar", "wat", "sommige", "is", "het", "u", "of", "had", "de", "van", "aan", "en", "een", "in", "we", "kan", "uit", "andere", "waren", "die", "doen", "hun", "tijd", "indien", "zal", "hoe", "zei", "een", "elk", "vertellen", "doet", "set", "drie", "willen", "lucht", "goed", "ook", "spelen", "klein", "end", "zetten", "thuis", "lezen", "de hand", "poort", "grote", "spell", "toevoegen", "zelfs", "land", "hier", "moet", "grote", "hoog", "dergelijke", "volgen", "act", "waarom", "vragen", "mannen", "verandering", "ging", "licht", "soort", "uitgeschakeld", "nodig hebben", "huis", "afbeelding", "proberen", "ons", "weer", "dier", "punt", "moeder", "wereld", "dichtbij", "bouwen", "zelf", "aarde", "vader", "een", "nieuwe", "werk", "deel", "nemen", "krijgen", "plaats", "gemaakt", "wonen", "waar", "na", "terug", "weinig", "alleen", "ronde", "man", "jaar", "kwam", "Show", "elke", "goed", "mij", "geven", "onze", "onder", "naam", "zeer", "door", "gewoon", "vorm", "zin", "grote", "denken", "zeggen", "helpen", "laag", "lijn", "verschillen", "beurt", "oorzaak", "veel", "betekenen", "voor", "verhuizing", "rechts", "jongen", "oude", "ook", "hetzelfde", "ze", "alle", "er", "wanneer", "omhoog", "gebruiken", "uw", "manier", "over", "veel", "dan", "hen", "schrijven", "zou", "zoals", "dus", "deze", "haar", "lang", "maken", "ding", "zien", "hem", "twee", "heeft", "kijken", "meer", "dag", "kon", "gaan", "komen", "deed", "aantal", "klinken", "geen", "meest", "mensen", "mijn", "meer dan", "weten", "water", "dan", "roep", "eerste", "die", "kan", "naar beneden", "kant", "geweest", "nu", "vinden", "hoofd", "staan", "eigen", "pagina", "moeten", "land", "gevonden", "antwoord", "de school", "groeien", "studie", "nog", "leren", "planten", "afdekking", "voedsel", "zon", "vier", "tussen", "staat", "houden", "oog", "nooit", "laatste", "laten", "gedachte", "stad", "boom", "oversteken", "boerderij", "hard", "begin", "zou", "verhaal", "zaag", "ver", "zee", "tekenen", "links", "laat", "lopen", "niet", "terwijl", "pers", "dicht", "nacht", "echt", "leven", "weinig", "noorden" };

            if (keuze == 1)
            {
                spel(nedArray, engArray);
            }

            if (keuze == 2)
            {
                woordenboek(nedArray, engArray);
            }
        }

        static void spel(string[] nedArray, string[] engArray)
        {
            Console.WriteLine("Hoeveel vragen moet er in de eerste ronde gesteld worden?");
            int antwoord = Int32.Parse(Console.ReadLine());
            int totaalscore = 0;

            for (int i = 0; i > antwoord; i++)
            {
                stelVraag(nedArray, engArray);
            }

            totaalscore = totaalscore + score;
            Console.WriteLine();
            Console.WriteLine($"Je score van ronde 1 is {totaalscore}");

            Console.WriteLine();
            Console.WriteLine("Ronde 2 start");
            suddenDeathRonde(nedArray, engArray);
        }

        static int suddenDeathRonde(string[] nedArray, string[] engArray)
        {
            int score2 = 0;


            return score2;
        }

        enum vraagSoort {nedNaarEng, engNaarNed};

        static int stelVraag(string[] nedArray, string[] engArray)
        {
            int score = 0;
            Random randomGenerator = new Random();
            Console.WriteLine();
            Console.WriteLine("Kies:");
            Console.WriteLine("1.ned naar eng of 2.eng naar ned");
            string keuze = Console.ReadLine();
            int woordnummer;

            if (nedNaarEng == vraagSoort.nedNaarEng)
            {
                woordnummer = randomGenerator.Next(1, nedArray.Length);
            }

            return score;
        }

        static void woordenboek(string[] nedArray, string[] engArray)
        {
            bool enabler = true;

            while (enabler = true)
            {
                Console.WriteLine();
                Console.WriteLine("Welk engels woord wenst u te vertalen?");
                string vertalen = Console.ReadLine();

                if (vertalen == "STOP")
                {
                    enabler = false;
                }

                else if (vertalen = engArray[vertalen])
                {
                    nedArray[engArray[vertalen]];
                    Console.WriteLine();
                    Console.WriteLine(nedArray);
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry, dit woord ken ik niet.");
                }
            }
        }
    }
}