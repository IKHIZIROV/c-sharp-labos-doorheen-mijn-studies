using System;

namespace Bib_Ismail_Khizirov
{
    public class InvalidBookDataException : Exception
    {
        public InvalidBookDataException() : base() { }
        public InvalidBookDataException(string message) : base(message) { }
        public InvalidBookDataException(string message, Exception inner) : base(message, inner) { }
    }

    public class BookNotAvailableException : Exception
    {
        public BookNotAvailableException() : base() { }
        public BookNotAvailableException(string message) : base(message) { }
        public BookNotAvailableException(string message, Exception inner) : base(message, inner) { }
    }
} 