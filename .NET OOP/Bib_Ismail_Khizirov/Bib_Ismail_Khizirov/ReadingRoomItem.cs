using System;

namespace Bib_Ismail_Khizirov
{
    public abstract class ReadingRoomItem
    {
        protected ReadingRoomItem(string title, string publisher)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty");
            if (string.IsNullOrWhiteSpace(publisher))
                throw new ArgumentException("Publisher cannot be empty");

            Title = title;
            Publisher = publisher;
        }

        public string Title { get; }
        public string Publisher { get; set; }
        public abstract string Identification { get; }
        public abstract string Category { get; }

        public override string ToString()
        {
            return $"{Title} ({Category}) - {Publisher}";
        }
    }
} 