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

        public static List<(Genre Genre, Book Book)> GenresGroupBooks()
        {
            var genresBooks =
                from Book in Data.Books
                join Genre in Data.Genres on Book.GenreId equals Genre.Id
                orderby Genre.Name
                select new { Genre, Book };

            return genresBooks.Select(i => (Genre: i.Genre, Book: i.Book)).ToList();
        }

        public static List<(Reader Reader, Book Book, RentedBook RentedBook)> ReadersRentedTime()
        {
            var readersTime =
                from Reader in Data.Readers
                join RentedBook in Data.RentedBooks on Reader.Id equals RentedBook.ReaderId
                join Book in Data.Books on RentedBook.BookId equals Book.Id
                orderby RentedBook.ReturnDate.Subtract(RentedBook.IssueDate)
                select new { Reader, Book, RentedBook };

            return readersTime.Select(i => (Reader: i.Reader, Book: i.Book, RentedBook: i.RentedBook)).ToList();
        }

        public static List<(Genre Genre, Book Book)> HorrorandDetectiveBooks()
        {
            var horrorAndDetective =
                from Book in Data.Books
                join Genre in Data.Genres on Book.GenreId equals Genre.Id
                where (Genre.Name == "Horror" || Genre.Name == "Detective")
                orderby Genre.Name
                select new { Book, Genre };

            return horrorAndDetective.Select(i => (Genre: i.Genre, Book: i.Book)).ToList();
        }

        public static List<(Author Author, Book Book)> BooksAuthorWithS()
        {
            var booksAuthorWithS =
                from Book in Data.Books
                join Author in Data.Authors on Book.AuthorId equals Author.Id
                where Author.Name.StartsWith("S")
                orderby Author.Name
                select new { Book, Author };

            return booksAuthorWithS.Select(i => (Author: i.Author, Book: i.Book)).ToList();
        }

        public static List<(Author Author, Book Book)> KingsBookPriceLower45()
        {
            var kingsBookPriceLower = Data.Books.Join(Data.Authors, Book => Book.AuthorId, Author => Author.Id, (Book, Author) => new { Book, Author })
                .Where(Book => Book.Author.Name == "Stephen King" && Book.Book.Deposit < 45);

            return kingsBookPriceLower.Select(i => (Author: i.Author, Book: i.Book)).ToList();
        }

        public static IEnumerable<Book> BookPriceForWeek()
        {
            var priceForWeek =
                from Book in Data.Books
                orderby (Book.RentPrice * 7)
                select Book;

            return priceForWeek.ToList();
        }

        public static int BooksPriceHigher40()
        {
            var booksPriceHigher40 =
                (from Book in Data.Books
                join Author in Data.Authors on Book.AuthorId equals Author.Id
                where (Author.Name != "Stephen King" && Book.Deposit > 40)
                orderby Book.Deposit
                select new { Book, Author }).Count();

            return booksPriceHigher40;
        }


    }
}
