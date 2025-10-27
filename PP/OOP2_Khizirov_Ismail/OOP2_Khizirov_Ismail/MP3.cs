using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Khizirov_Ismail
{
    enum MP3formaat { VBR, CBR, onbekend }
    class MP3 : MuziekItem
    {
        public MP3(string naam, int duur, MP3formaat formaat) : base(naam, 5)
        {
            Inhoud = $"{formaat} MP3";
        }
    }
}
