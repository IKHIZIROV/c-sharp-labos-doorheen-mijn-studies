using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib_Ismail_Khizirov
{
    class Book : ILendable
    {
		public enum Genre
		{
			Thriller, Action, Detective, Adventure, Horror, Comedy, Fiction, Fantasy, Schoolbook
		}

        public enum Languages
        {
            Nederlands,
            Engels,
            Frans,
            Duits,
            Spaans
        }

        public Book(string title, string author)
        {
            if (title == null || title == "")
                throw new InvalidBookDataException("Titel mag niet leeg zijn");
            if (author == null || author == "")
                throw new InvalidBookDataException("Auteur mag niet leg zijn");

            Title = title;
            Author = author;
            IsAvailable = true;
            BorrowDays = 20;
        }

        private string author;
        public string Author
        {
            get { return author; }
            set
            {
                if (value == null || value == "")
                    throw new InvalidBookDataException("Auteur mag niet leeg zijn");
                author = value;
            }
        }

        private string publisher;
        public string Publisher
        {
            get { return publisher; }
            set
            {
                if (value == null || value == "")
                    throw new InvalidBookDataException("Uitgever mag niet leeg zijn");
                publisher = value;
            }
        }

        private int pagesAmount;
        public int PagesAmount
        {
            get { return pagesAmount; }
            set
            {
                if (value <= 0)
                    throw new InvalidBookDataException("Aantal pagina's moet groter zijn dan 0");
                pagesAmount = value;
            }
        }

        private Languages language;
        public Languages Language
        {
            get { return language; }
            set { language = value; }
        }

        private int minimumAge;
        public int MinimumAge
        {
            get { return minimumAge; }
            set
            {
                if (value < 0 || value > 120)
                    throw new InvalidBookDataException("Minimum leeftijd moet tussen 0 en 120 liggen");
                minimumAge = value;
            }
        }

        private Genre bookGenre;
        public Genre BookGenre
        {
            get { return bookGenre; }
            set 
            { 
                bookGenre = value;
                BorrowDays = value == Genre.Schoolbook ? 10 : 20;
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                    if (value == null || value == "")
                    throw new InvalidBookDataException("Titel mag niet leeg zijn");
                title = value;
            }
        }

        private string isbn;
        public string ISBN
        {
            get { return isbn; }
            set
            {
                if (value == null || value == "" || value.Length != 13)
                    throw new InvalidBookDataException("ISBN moet exact 13 cijfers bevatten");
                isbn = value;
            }
        }

        private DateTime publicationYear;
        public DateTime PublicationYear
        {
            get { return publicationYear; }
            set
            {
                if (value > DateTime.Now)
                    throw new InvalidBookDataException("Publicatiejaar kan niet in de toekomst liggen");
                publicationYear = value;
            }
        }

        public bool IsAvailable { get; set; }
        public DateTime BorrowingDate { get; set; }
        public int BorrowDays { get; set; }

        public void Borrow()
        {
            if (!IsAvailable)
                throw new BookNotAvailableException($"Boek '{Title}' is momenteel niet beschikbaar");

            IsAvailable = false;
            BorrowingDate = DateTime.Now;
            DateTime returnDate = BorrowingDate.AddDays(BorrowDays);
            Console.WriteLine($"\nBoek '{Title}' is uitgeleend.");
            Console.WriteLine($"Uiterste terugbrengdatum: {returnDate:dd/MM/yyyy}");
        }

        public void Return()
        {
            if (IsAvailable)
                throw new BookNotAvailableException($"Boek '{Title}' is al teruggebracht");

            IsAvailable = true;
            DateTime returnDate = DateTime.Now;
            DateTime dueDate = BorrowingDate.AddDays(BorrowDays);

            if (returnDate > dueDate)
            {
                TimeSpan late = returnDate - dueDate;
                Console.WriteLine($"\nBoek '{Title}' is {late.Days} dagen te laat teruggebracht!");
            }
            else
            {
                Console.WriteLine($"\nBoek '{Title}' is op tijd teruggebracht.");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nDetails van het boek: {Title}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Auteur: {Author}");
            Console.WriteLine($"Uitgever: {Publisher}");
            Console.WriteLine($"Genre: {BookGenre}");
            Console.WriteLine($"Jaar van publicatie: {PublicationYear:yyyy}");
            Console.WriteLine($"Taal: {Language}");
            Console.WriteLine($"Vereiste leeftijd om te lezen: {MinimumAge}");
            Console.WriteLine($"Aantal pagina's: {PagesAmount}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Beschikbaar: {(IsAvailable ? "Ja" : "Nee")}");
            if (!IsAvailable)
            {
                Console.WriteLine($"Uitgeleend op: {BorrowingDate:dd/MM/yyyy}");
                Console.WriteLine($"Uiterste terugbrengdatum: {BorrowingDate.AddDays(BorrowDays):dd/MM/yyyy}");
            }
            Console.WriteLine("----------------------------------------\n");
        }

        public override string ToString()
        {
            return $"{Title} door {Author} ({(IsAvailable ? "Beschikbaar" : "Uitgeleend")})";
        }
	}
}


