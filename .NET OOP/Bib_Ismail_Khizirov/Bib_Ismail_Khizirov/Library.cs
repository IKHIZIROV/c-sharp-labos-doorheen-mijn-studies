using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bib_Ismail_Khizirov
{
    class Library
    {
        public Library(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        private List<Book> books = new List<Book>();
        private Dictionary<DateTime, ReadingRoomItem> allReadingRoom = new Dictionary<DateTime, ReadingRoomItem>();

        public IReadOnlyDictionary<DateTime, ReadingRoomItem> AllReadingRoom
        {
            get { return allReadingRoom; }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Boek '{book.Title}' is toegevoegd aan de bibliotheek.");
        }

        public void AddNewspaper()
        {
            Console.WriteLine("\nNieuwe krant toevoegen:");
            Console.WriteLine("Geef de naam van de krant:");
            string title = Console.ReadLine();
            Console.WriteLine("Geef de uitgeverij:");
            string publisher = Console.ReadLine();
            Console.WriteLine("Geef de datum van de krant in (YYYY-MM-DD):");
            string dateInput = Console.ReadLine();
            DateTime date;
            try
            {
                date = Convert.ToDateTime(dateInput);
            }
            catch
            {
                Console.WriteLine("Ongeldige datum! Gebruik het formaat YYYY-MM-DD.");
                return;
            }

            try
            {
                NewsPaper newspaper = new NewsPaper(title, publisher, date);
                allReadingRoom.Add(DateTime.Now, newspaper);
                Console.WriteLine($"Krant '{newspaper.Title}' is toegevoegd aan de leeszaal.");
                Console.WriteLine($"Identificatie: {newspaper.Identification}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fout bij het toevoegen van de krant: {ex.Message}");
            }
        }

        public void AddMagazine()
        {
            Console.WriteLine("\nNieuw maandblad toevoegen:");
            Console.WriteLine("Geef de naam van het maandblad:");
            string title = Console.ReadLine();
            Console.WriteLine("Geef de uitgeverij:");
            string publisher = Console.ReadLine();
            Console.WriteLine("Geef de maand van het maandblad in (1-12):");
            string monthInput = Console.ReadLine();
            byte month;
            try
            {
                month = Convert.ToByte(monthInput);
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Ongeldige maand! Voer een getal in tussen 1 en 12.");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Ongeldige invoer! Voer een getal in tussen 1 en 12.");
                return;
            }

            Console.WriteLine("Geef het jaar van het maandblad in:");
            string yearInput = Console.ReadLine();
            uint year;
            try
            {
                year = Convert.ToUInt32(yearInput);
                if (year < 1900 || year > DateTime.Now.Year)
                {
                    Console.WriteLine($"Ongeldig jaar! Voer een getal in tussen 1900 en {DateTime.Now.Year}.");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Ongeldige invoer! Voer een geldig jaar in.");
                return;
            }

            try
            {
                Magazine magazine = new Magazine(title, publisher, month, year);
                allReadingRoom.Add(DateTime.Now, magazine);
                Console.WriteLine($"Maandblad '{magazine.Title}' is toegevoegd aan de leeszaal.");
                Console.WriteLine($"Identificatie: {magazine.Identification}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fout bij het toevoegen van het maandblad: {ex.Message}");
            }
        }

        public void ShowAllMagazines()
        {
            bool hasMagazines = false;
            foreach (var item in allReadingRoom.Values)
            {
                if (item is Magazine)
                {
                    hasMagazines = true;
                    break;
                }
            }

            if (!hasMagazines)
            {
                Console.WriteLine("Er zijn geen maandbladen in de leeszaal.");
                return;
            }

            Console.WriteLine("\nMaandbladen in de leeszaal:");
            Console.WriteLine("----------------------------------------");
            foreach (var item in allReadingRoom.Values)
            {
                if (item is Magazine magazine)
                {
                    Console.WriteLine(magazine.ToString());
                }
            }
            Console.WriteLine("----------------------------------------\n");
        }

        public void ShowAllNewspapers()
        {
            bool hasNewspapers = false;
            foreach (var item in allReadingRoom.Values)
            {
                if (item is NewsPaper)
                {
                    hasNewspapers = true;
                    break;
                }
            }

            if (!hasNewspapers)
            {
                Console.WriteLine("Er zijn geen kranten in de leeszaal.");
                return;
            }

            Console.WriteLine("\nKranten in de leeszaal:");
            Console.WriteLine("----------------------------------------");
            foreach (var item in allReadingRoom.Values)
            {
                if (item is NewsPaper newspaper)
                {
                    Console.WriteLine(newspaper.ToString());
                }
            }
            Console.WriteLine("----------------------------------------\n");
        }

        public void ShowAcquisitionsReadingRoomToday()
        {
            DateTime today = DateTime.Today;
            List<ReadingRoomItem> acquisitions = new List<ReadingRoomItem>();

            foreach (var item in allReadingRoom)
            {
                if (item.Key.Date == today)
                {
                    acquisitions.Add(item.Value);
                }
            }

            if (acquisitions.Count == 0)
            {
                Console.WriteLine("Er zijn geen nieuwe aanwinsten vandaag.");
                return;
            }

            Console.WriteLine("\nAanwinsten van vandaag:");
            Console.WriteLine("----------------------------------------");
            foreach (var item in acquisitions)
            {
                Console.WriteLine($"{item.Title} - {item.Identification}");
            }
            Console.WriteLine("----------------------------------------\n");
        }

        public void ShowAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("De bibliotheek bevat nog geen boeken.");
                return;
            }

            Console.WriteLine($"\nBoeken in {Name}:");
            Console.WriteLine("----------------------------------------");
            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }
            Console.WriteLine("----------------------------------------\n");
        }

        public void RemoveBook(Book book)
        {
            if (books.Remove(book))
                Console.WriteLine($"Boek '{book.Title}' is verwijderd uit de bibliotheek.");
            else
                Console.WriteLine($"Boek '{book.Title}' werd niet gevonden in de bibliotheek.");
        }

        public Book SearchBookBasedOnTitleAndAuthor(string title, string author)
        {
            foreach (var book in books)
            {
                if (book.Title.ToLower() == title.ToLower() && 
                    book.Author.ToLower() == author.ToLower())
                {
                    return book;
                }
            }
            return null;
        }

        public Book SearchBookBasedOnTitle(string title)
        {
            foreach (var book in books)
            {
                if (book.Title.ToLower() == title.ToLower())
                {
                    return book;
                }
            }
            return null;
        }

        public Book SearchBookBasedOnISBN(string isbn)
        {
            foreach (var book in books)
            {
                if (book.ISBN == isbn)
                {
                    return book;
                }
            }
            return null;
        }

        public List<Book> SearchAllBooksOfAuthor(string author)
        {
            List<Book> result = new List<Book>();
            foreach (var book in books)
            {
                if (book.Author.ToLower() == author.ToLower())
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public List<Book> SearchAllBooksBasedOnAge(int age)
        {
            List<Book> result = new List<Book>();
            foreach (var book in books)
            {
                if (book.MinimumAge >= age)
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public void ImportBooksFromCSV(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("CSV bestand niet gevonden", filePath);

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                bool isFirstLine = true;
                foreach (var line in lines)
                {
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }

                    string[] values = line.Split(',');
                    if (values.Length >= 2)
                    {
                        Book book = new Book(values[0].Trim(), values[1].Trim());
                        
                        if (values.Length > 2 && !string.IsNullOrWhiteSpace(values[2]))
                            book.ISBN = values[2].Trim();
                        
                        if (values.Length > 3 && !string.IsNullOrWhiteSpace(values[3]))
                            book.Publisher = values[3].Trim();
                        
                        if (values.Length > 4 && !string.IsNullOrWhiteSpace(values[4]))
                            book.PagesAmount = int.Parse(values[4].Trim());
                        
                        if (values.Length > 5 && !string.IsNullOrWhiteSpace(values[5]))
                            book.MinimumAge = int.Parse(values[5].Trim());
                        
                        if (values.Length > 6 && !string.IsNullOrWhiteSpace(values[6]))
                            book.BookGenre = (Book.Genre)Enum.Parse(typeof(Book.Genre), values[6].Trim());
                        
                        if (values.Length > 7 && !string.IsNullOrWhiteSpace(values[7]))
                            book.Language = (Book.Languages)Enum.Parse(typeof(Book.Languages), values[7].Trim());
                        
                        if (values.Length > 8 && !string.IsNullOrWhiteSpace(values[8]))
                            book.PublicationYear = DateTime.Parse(values[8].Trim());

                        AddBook(book);
                    }
                }
                Console.WriteLine("CSV bestand succesvol geïmporteerd.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fout bij het importeren van het CSV bestand: {ex.Message}");
            }
        }
    }
}
