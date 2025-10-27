using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib_Ismail_Khizirov
{
    public class NewsPaper : ReadingRoomItem
    {
        private static readonly Dictionary<string, string> NewspaperAbbreviations = new Dictionary<string, string>
        {
            { "De Standaard", "DS" },
            { "Het Nieuwsblad", "HN" },
            { "De Morgen", "DM" },
            { "Het Laatste Nieuws", "HLN" },
            { "De Tijd", "DT" },
            { "Gazet van Antwerpen", "GVA" },
            { "Het Belang van Limburg", "HBVL" }
        };

        private readonly string identification;
        private readonly DateTime publicationDate;

        public NewsPaper(string title, string publisher, DateTime date) : base(title, publisher)
        {
            if (date > DateTime.Now)
            {
                throw new ArgumentException("Publication date cannot be in the future", nameof(date));
            }

            publicationDate = date;

            string abbreviation = null;
            foreach (var pair in NewspaperAbbreviations)
            {
                if (pair.Key.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    abbreviation = pair.Value;
                    break;
                }
            }

            if (abbreviation == null)
            {
                if (title.Length < 3)
                {
                    throw new ArgumentException("Title must be at least 3 characters long when no abbreviation is found", nameof(title));
                }
                abbreviation = title.Substring(0, 3).ToUpper();
            }

            identification = abbreviation;
        }

        public override string Identification
        {
            get { return identification; }
        }

        public override string Category
        {
            get { return "Krant"; }
        }

        public override string ToString()
        {
            return $"{Title} ({Identification}) - {Publisher} - {publicationDate.ToShortDateString()}";
        }
    }
} 