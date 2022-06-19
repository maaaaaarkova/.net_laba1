using System;
using System.Collections.Generic;
using System.Text;
using laba1.Models;
using laba1.Models.Enum;
using System.Linq;

namespace laba1
{
    public static class Queries
    {
        public static IEnumerable<Reader> ReadersInfo()
        {
            var readerInfo =
                from Reader in Data.Readers
                select Reader;

            return readerInfo.ToList();
        }

        public static List <(Genre Genre, Author Author, Book Book)> BooksInfo()
        {
            var booksInfo =
                from Book in Data.Books
                join Author in Data.Authors on Book.AuthorId equals Author.Id
                join Genre in Data.Genres on Book.GenreId equals Genre.Id
                select new { Book, Author, Genre };

            return booksInfo.Select(i => (Genre: i.Genre, Author: i.Author, Book: i.Book)).ToList();       
        }

        public static IEnumerable<Author> AuthorsSortedInfo()
        {
            var authorsSortedInfo =
                from Author in Data.Authors
                orderby Author.Name
                select Author;

            return authorsSortedInfo.ToList();
        }

        public static List<(Genre Genre, Author Author, Book Book)> BooksPriceOver40()
        {
            var bookPriceOver =
                from Book in Data.Books
                join Author in Data.Authors on Book.AuthorId equals Author.Id
                join Genre in Data.Genres on Book.GenreId equals Genre.Id
                where Book.Deposit >= 40
                select new { Book, Author, Genre };

            return bookPriceOver.Select(i => (Genre: i.Genre, Author: i.Author, Book: i.Book)).ToList();

        }

        public static IEnumerable<Reader> ReaderNameStartsWithOInfo()
        {
            var nameStartsWithO =
                from Reader in Data.Readers
                where Reader.Name.StartsWith("O")
                select Reader;

            return nameStartsWithO.ToList();
        }

        public static List<(Author Author, Book Book)> StephenKingBooks()
        {
            var kingsBooks =
                from Book in Data.Books
                join Author in Data.Authors on Book.AuthorId equals Author.Id
                where Author.Name == "Stephen King"
                select new { Book, Author };

            return kingsBooks.Select(i => (Author: i.Author, Book: i.Book)).ToList();
        }

        public static IEnumerable<Reader> SortedCollegeStudents()
        {
            var sortedCollegeStudent =
                from Reader in Data.Readers
                where Reader.Category == Category.CollegeStudent
                orderby Reader.LastName
                select Reader;

            return sortedCollegeStudent.ToList();
        }

        public static List<(Reader Reader, Book Book)> ReadersRentedBooks()
        {
            var readersBooks =
                from Reader in Data.Readers
                join RentedBook in Data.RentedBooks on Reader.Id equals RentedBook.ReaderId
                join Book in Data.Books on RentedBook.BookId equals Book.Id
                select new { Reader, Book };

            return readersBooks.Select(i => (Reader: i.Reader, Book: i.Book)).ToList();
        }
    }
}
