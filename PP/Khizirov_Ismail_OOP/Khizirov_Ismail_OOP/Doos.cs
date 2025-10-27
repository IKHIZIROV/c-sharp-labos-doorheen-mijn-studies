using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khizirov_Ismail_OOP
{
    abstract class Doos
    {
        public Doos(int id)
        {
            ID = id;
        }

        public int ID { get; private set; }
        public int Gewicht { get; set; }
        public string Inhoud { get; set; }

        public virtual int KostPrijs
        {
            get { return Gewicht * 10; }
        }
    }
}
