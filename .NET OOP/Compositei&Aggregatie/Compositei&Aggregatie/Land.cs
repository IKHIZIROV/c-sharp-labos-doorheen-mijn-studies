using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositei_Aggregatie
{
    public class Land
    {
        private President President;
        private Minister EersteMinister;
        private List<Minister> Ministers = new List<Minister>(4);

        public void MaakRegering(President presin, List<Minister> minin)
        {
            if (President == null)
            {
                President = presin;
                EersteMinister = minin[0];
                if (minin.Count >= 2)
                    for (int i = 1; i < minin.Count; i++)
                    {
                        Ministers.Add(minin[i]);
                    }
            }

            else
            {
                Console.WriteLine("Gaat niet. Dit land heeft al een regering");
            }
        }

        public void JaarVerder()
        {
            if (President != null)
            {
                President.JaarVerder();
                if (President.Teller <= 0)
                {
                    Console.WriteLine("Regering is gedaan");
                    President = null;
                    EersteMinister = null;
                    Ministers.Clear();
                }
            }
        }
    }
}
