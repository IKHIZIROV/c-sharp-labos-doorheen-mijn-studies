using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib_Ismail_Khizirov
{
    public class Magazine : ReadingRoomItem
    {
        private static readonly Dictionary<string, string> MagazineAbbreviations = new Dictionary<string, string>
        {
            { "National Geographic", "NG" },
            { "Time", "TIME" },
            { "Newsweek", "NW" },
            { "The Economist", "TE" },
            { "Scientific American", "SA" },
            { "Popular Science", "PS" },
            { "Wired", "WIRED" }
        };

        private byte month;
        private uint year;

        public Magazine(string title, string publisher, byte month, uint year) : base(title, publisher)
        {
            this.month = month;
            this.year = year;
        }

        public byte Month
        {
            get { return month; }
        }

        public uint Year
        {
            get { return year; }
        }

        public override string Identification
        {
            get
            {
                string abbreviation = null;
                foreach (var pair in MagazineAbbreviations)
                {
                    if (pair.Key.ToLower() == Title.ToLower())
                    {
                        abbreviation = pair.Value;
                        break;
                    }
                }
                return abbreviation ?? Title.Substring(0, Math.Min(3, Title.Length)).ToUpper();
            }
        }

        public override string Category
        {
            get { return "Maandblad"; }
        }

        public override string ToString()
        {
            return $"{Title} ({Identification}) - {Publisher} - {month}/{year}";
        }
    }
} 