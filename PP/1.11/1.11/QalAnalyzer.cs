using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._11
{
    class QalAnalyzer
    {
        public static void SummarizeDiary(List<DagboekEntry> log)
        {
            foreach (var item in log)
            {
                item.ShowInfo();
            }
        }

        public static void AnalyseDiary(List<DagboekEntry> log)
        {
            int qal = 0;
            int somisinspired = 0;

            foreach (var item in log)
            {
                if (item.IsInspired = true)
                    somisinspired++;
                if (!item.IsPrivate)
                    qal+=item.Qal;
            }

            Console.WriteLine($"De som van uw qal is {qal}");
            Console.WriteLine($"U bent {somisinspired} keer geïnspireerd geweest.");
        }

        public static List<DagboekEntry> CreateDiary()
        {
            Console.WriteLine("Rise and shine");
            Console.WriteLine($"Het is nu {DateTime.Now}");

            Console.WriteLine("Hoeveel dagen wil je loggen?");
            int aantalDagen = Convert.ToInt32(Console.ReadLine());
            List<DagboekEntry> diary = new List<DagboekEntry>();
            for (int i = 0; i < aantalDagen; i++)
            {
                DagboekEntry l = new DagboekEntry();
                Console.WriteLine($"Dag {i + 1}: {DateTime.Now.AddDays(i).DayOfWeek}");
                Console.WriteLine("Hoe was je dag?");
                l.Description = Console.ReadLine();
                Console.WriteLine("Voelde je je geïnspireerd?(y/n)");
                string inspired = Console.ReadLine();
                if (inspired == "y")
                    l.IsInspired = true;

                Console.WriteLine("Welke score geef je deze dag?");
                int score = Convert.ToInt32(Console.ReadLine());
                l.Qal = score;

                Console.WriteLine("Is dit een private entry?(y/n)");
                string prive = Console.ReadLine();
                if (prive == "y")
                {
                    l.MakePrivate(true);
                }

                diary.Add(l);
            }

            return diary;
        }
    }
}
