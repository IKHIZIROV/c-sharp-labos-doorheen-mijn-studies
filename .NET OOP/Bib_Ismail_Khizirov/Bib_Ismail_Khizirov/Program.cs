namespace Bib_Ismail_Khizirov
{
    internal class Program
    {
        static Library library = new Library("Cookie's secret underground library");

        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                try
                {
                    keepGoing = ShowMainMenu();
                }
                catch (InvalidBookDataException ex)
                {
                    Console.WriteLine($"\nFout bij het verwerken van boekgegevens: {ex.Message}");
                    Console.WriteLine("Druk op een toets om door te gaan...");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (BookNotAvailableException ex)
                {
                    Console.WriteLine($"\nFout bij het uitlenen/terugbrengen: {ex.Message}");
                    Console.WriteLine("Druk op een toets om door te gaan...");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nEr is een onverwachte fout opgetreden: {ex.Message}");
                    Console.WriteLine("Druk op een toets om door te gaan...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        public static bool ShowMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Welkom! Wat wil je doen?");
            Console.WriteLine("");
            Console.WriteLine("1. Een boek toevoegen aan je bibliotheek");
            Console.WriteLine("2. Informatie aan een boek toevoegen");
            Console.WriteLine("3. Alle informatie over een boek tonen");
            Console.WriteLine("4. Een boek/boeken zoeken");
            Console.WriteLine("5. Een boek verwijderen uit je bibliotheek");
            Console.WriteLine("6. Alle boeken tonen uit je bibliotheek");
            Console.WriteLine("7. Een csv-bestand inlezen");
            Console.WriteLine("8. Een krant toevoegen aan de leeszaal");
            Console.WriteLine("9. Een maandblad toevoegen aan de leeszaal");
            Console.WriteLine("10. Alle kranten tonen");
            Console.WriteLine("11. Alle maandbladen tonen");
            Console.WriteLine("12. Aanwinsten van vandaag tonen");
            Console.WriteLine("13. Een boek uitlenen");
            Console.WriteLine("14. Een boek terugbrengen");
            Console.WriteLine("15. Programma afsluiten");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");

            string input = Console.ReadLine();
            int number;

            try
            {
                number = Convert.ToInt32(input);
            }
            catch
            {
                Console.WriteLine("Ongeldige invoer! Voer een nummer in.");
                return true;
            }

            switch (number)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Geef de titel van uw boek:");
                    string title = Console.ReadLine();
                    Console.WriteLine("Geef de auteur van uw boek:");
                    string author = Console.ReadLine();

                    if (title == null || title == "" || author == null || author == "")
                    {
                        Console.WriteLine("Geef een geldige input!");
                        return true;
                    }

                    Book book = new Book(title, author);
                    library.AddBook(book);
                    return true;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Van welk boek wil je de informatie bewerken?: \n");
                    library.ShowAllBooks();

                    Console.WriteLine("\nGeef de titel van het boek: ");
                    string searchTitle = Console.ReadLine();
                    Book bookToEdit = library.SearchBookBasedOnTitle(searchTitle);

                    if (bookToEdit == null)
                    {
                        Console.WriteLine("Boek niet gevonden!");
                        return true;
                    }

                    ShowInfoMenu(bookToEdit);
                    return true;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Geef de titel van het boek: ");
                    string bookTitle = Console.ReadLine();
                    Book bookToShow = library.SearchBookBasedOnTitle(bookTitle);

                    if (bookToShow == null)
                    {
                        Console.WriteLine("Boek niet gevonden!");
                        return true;
                    }

                    bookToShow.ShowInfo();
                    return true;

                case 4:
                    Console.Clear();
                    ShowSearchMenu();
                    return true;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Geef de titel van het boek dat je wilt verwijderen: ");
                    string bookToRemove = Console.ReadLine();
                    Book bookToDelete = library.SearchBookBasedOnTitle(bookToRemove);

                    if (bookToDelete == null)
                    {
                        Console.WriteLine("Boek niet gevonden!");
                        return true;
                    }

                    library.RemoveBook(bookToDelete);
                    return true;

                case 6:
                    Console.Clear();
                    library.ShowAllBooks();
                    return true;

                case 7:
                    Console.Clear();
                    Console.WriteLine("Geef het pad naar het CSV bestand: ");
                    string filePath = Console.ReadLine();
                    library.ImportBooksFromCSV(filePath);
                    return true;

                case 8:
                    Console.Clear();
                    library.AddNewspaper();
                    return true;

                case 9:
                    Console.Clear();
                    library.AddMagazine();
                    return true;

                case 10:
                    Console.Clear();
                    library.ShowAllNewspapers();
                    return true;

                case 11:
                    Console.Clear();
                    library.ShowAllMagazines();
                    return true;

                case 12:
                    Console.Clear();
                    library.ShowAcquisitionsReadingRoomToday();
                    return true;

                case 13:
                    Console.Clear();
                    Console.WriteLine("Geef de titel van het boek dat je wilt uitlenen: ");
                    string bookToBorrow = Console.ReadLine();
                    Book bookToLend = library.SearchBookBasedOnTitle(bookToBorrow);

                    if (bookToLend == null)
                    {
                        Console.WriteLine("Boek niet gevonden!");
                        return true;
                    }

                    bookToLend.Borrow();
                    return true;

                case 14:
                    Console.Clear();
                    Console.WriteLine("Geef de titel van het boek dat je wilt terugbrengen: ");
                    string bookToReturn = Console.ReadLine();
                    Book bookToBringBack = library.SearchBookBasedOnTitle(bookToReturn);

                    if (bookToBringBack == null)
                    {
                        Console.WriteLine("Boek niet gevonden!");
                        return true;
                    }

                    bookToBringBack.Return();
                    return true;

                case 15:
                    Console.WriteLine("Applicatie wordt beëindigd...");
                    return false;

                default:
                    Console.Clear();
                    Console.WriteLine("Fout! Geef een geldige input!");
                    return true;
            }
        }

        public static void ShowInfoMenu(Book book)
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Welke informatie wil je toevoegen?");
            Console.WriteLine("");
            Console.WriteLine("1. ISBN");
            Console.WriteLine("2. Genre");
            Console.WriteLine("3. Aantal pagina's");
            Console.WriteLine("4. Minimum leeftijd");
            Console.WriteLine("5. Uitgever");
            Console.WriteLine("6. Taal");
            Console.WriteLine("7. Publicatiejaar");
            Console.WriteLine("8. Ga terug naar de hoofdmenu");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");

            string input = Console.ReadLine();
            int number;
            try
            {
                number = Convert.ToInt32(input);
            }
            catch
            {
                Console.WriteLine("Ongeldige invoer! Voer een nummer in.");
                return;
            }

            try
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Geef de ISBN in (13 cijfers):");
                        book.ISBN = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Geef het genre in:");
                        Console.WriteLine("Beschikbare genres: " + string.Join(", ", Enum.GetNames(typeof(Book.Genre))));
                        book.BookGenre = (Book.Genre)Enum.Parse(typeof(Book.Genre), Console.ReadLine(), true);
                        break;

                    case 3:
                        Console.WriteLine("Geef het aantal pagina's in:");
                        book.PagesAmount = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("Geef de minimum leeftijd in:");
                        book.MinimumAge = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("Geef de uitgever in:");
                        book.Publisher = Console.ReadLine();
                        break;

                    case 6:
                        Console.WriteLine("Geef de taal in:");
                        Console.WriteLine("Beschikbare talen: " + string.Join(", ", Enum.GetNames(typeof(Book.Languages))));
                        book.Language = (Book.Languages)Enum.Parse(typeof(Book.Languages), Console.ReadLine(), true);
                        break;

                    case 7:
                        Console.WriteLine("Geef het publicatiejaar in (YYYY-MM-DD):");
                        book.PublicationYear = Convert.ToDateTime(Console.ReadLine());
                        break;

                    case 8:
                        Console.Clear();
                        return;

                    default:
                        Console.WriteLine("Fout! Je hebt geen geldige input gegeven!");
                        return;
                }
                Console.WriteLine("Informatie succesvol toegevoegd!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fout bij het toevoegen van informatie: {ex.Message}");
            }
        }

        public static void ShowSearchMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Wat wil je doen?");
            Console.WriteLine("");
            Console.WriteLine("1. Een boek zoeken op basis van titel en auteur");
            Console.WriteLine("2. Een boek zoeken op basis van ISBN");
            Console.WriteLine("3. Alle boeken zoeken van een auteur");
            Console.WriteLine("4. Alle boeken zoeken met een bepaalde minimumleeftijd");
            Console.WriteLine("5. Ga terug naar de hoofdmenu");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");

            string input = Console.ReadLine();
            int number;
            try
            {
                number = Convert.ToInt32(input);
            }
            catch
            {
                Console.WriteLine("Ongeldige invoer! Voer een nummer in.");
                return;
            }

            try
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Geef de titel in:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Geef de auteur in:");
                        string author = Console.ReadLine();
                        Book book = library.SearchBookBasedOnTitleAndAuthor(title, author);
                        if (book != null)
                            book.ShowInfo();
                        else
                            Console.WriteLine("Boek niet gevonden!");
                        break;

                    case 2:
                        Console.WriteLine("Geef de ISBN in:");
                        string isbn = Console.ReadLine();
                        Book bookByISBN = library.SearchBookBasedOnISBN(isbn);
                        if (bookByISBN != null)
                            bookByISBN.ShowInfo();
                        else
                            Console.WriteLine("Boek niet gevonden!");
                        break;

                    case 3:
                        Console.WriteLine("Geef de naam van de auteur in:");
                        string authorName = Console.ReadLine();
                        var booksByAuthor = library.SearchAllBooksOfAuthor(authorName);
                        if (booksByAuthor.Any())
                        {
                            Console.WriteLine($"\nBoeken van {authorName}:");
                            foreach (var b in booksByAuthor)
                                Console.WriteLine(b.ToString());
                        }
                        else
                            Console.WriteLine("Geen boeken gevonden van deze auteur!");
                        break;

                    case 4:
                        Console.WriteLine("Geef de minimum leeftijd in:");
                        int age;
                        try
                        {
                            age = Convert.ToInt32(Console.ReadLine());
                            var booksByAge = library.SearchAllBooksBasedOnAge(age);
                            if (booksByAge.Any())
                            {
                                Console.WriteLine($"\nBoeken met minimum leeftijd {age}:");
                                foreach (var b in booksByAge)
                                    Console.WriteLine(b.ToString());
                            }
                            else
                                Console.WriteLine("Geen boeken gevonden met deze minimum leeftijd!");
                        }
                        catch
                        {
                            Console.WriteLine("Ongeldige leeftijd!");
                        }
                        break;

                    case 5:
                        Console.Clear();
                        return;

                    default:
                        Console.WriteLine("Fout! Je hebt geen geldige input gegeven!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fout bij het zoeken: {ex.Message}");
            }
        }
    }
}
