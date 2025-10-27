using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Khizirov_Ismail
{
    class MuziekItem
    {
        private string inhoud = "onbekend";
        public string Inhoud
        {
            get
            {
                return inhoud;
            }
            protected set
            {
                    inhoud = value;
            }
        }

        public string Naam { get; set; }
        public int Duur { get; set; }

        public MuziekItem(string naam, int duur)
        {

        }

        public virtual void ToonInfo()
        {
            ToString();
        }

        public override string ToString()
        {
            return $"{Naam} : {Duur} : {Inhoud}";
        }
    }
}
