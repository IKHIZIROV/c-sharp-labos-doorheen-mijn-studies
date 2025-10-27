namespace Hf6_Oefenen
{
    internal class Program
    {

            static string PaswoordGenerator(int lengte)
            {
                string resultaat = "";
                Random r = new Random();
                for (int i = 0; i < lengte; i++)
                {
                    switch (r.Next(0, 3))
                    {
                        case 0: //cijfer
                            resultaat += r.Next(0, 10);
                            break;
                        case 1: //kleine letters
                            resultaat += (char)r.Next('a', 'z' + 1);
                            break;
                        case 2: //hoofdletters
                            resultaat += (char)r.Next('A', 'Z' + 1);
                            break;
                    }
                }
                return resultaat;
            }
        }
    }