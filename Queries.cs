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

            return readerInfo;
        }

        public static IEnumerable<BooksInfoViewModel> BooksInfo()
        {
            var booksInfo =
                from Book in Data.Books
                join Author in Data.Authors on Book.AuthorId equals Author.Id
                join Genre in Data.Genres on Book.GenreId equals Genre.Id
                select new BooksInfoViewModel() { Book = Book, Author = Author, Genre = Genre };

            return booksInfo;       
        }

        public static IEnumerable<Author> AuthorsSortedInfo()
        {
            var authorsSortedInfo =
                from Author in Data.Authors
                orderby Author.Name
                select Author;

            return authorsSortedInfo;
        }

        public static IEnumerable<BooksInfoViewModel> BooksPriceOver40()
        {
            var bookPriceOver =
                from Book in Data.Books
                join Author in Data.Authors on Book.AuthorId equals Author.Id
                join Genre in Data.Genres on Book.GenreId equals Genre.Id
                where Book.Deposit >= 40
                select new BooksInfoViewModel() { Book = Book, Author = Author, Genre = Genre };

            return bookPriceOver;

        }

        public static IEnumerable<Reader> ReaderNameStartsWithOInfo()
        {
            var nameStartsWithO = Data.Readers.Where(i => i.Name.StartsWith("O"));

            return nameStartsWithO;
        }

        public static IEnumerable<AuthorBookViewModel> StephenKingBooks()
        {
            var kingsBooks =
                from Book in Data.Books
                join Author in Data.Authors on Book.AuthorId equals Author.Id
                where Author.Name == "Stephen King"
                select new AuthorBookViewModel() { Book = Book, Author = Author };

            return kingsBooks;
        }


        public static IEnumerable<Reader> SortedCollegeStudents()
        {
            var sortedCollegeStudent = Data.Readers.Where(i => i.Category == Category.CollegeStudent).OrderBy(i => i.LastName);

            return sortedCollegeStudent;
        }

        public static IEnumerable<ReaderBookViewModel> ReadersRentedBooks()
        {
            var readersBooks =
                from Reader in Data.Readers
                join RentedBook in Data.RentedBooks on Reader.Id equals RentedBook.ReaderId
                join Book in Data.Books on RentedBook.BookId equals Book.Id
                select new ReaderBookViewModel() { Reader = Reader, Book = Book };

            return readersBooks;
        }

        public static IEnumerable<GenreBookViewModel> GenresGroupBooks()
        {
            var genresBooks =
                from Book in Data.Books
                join Genre in Data.Genres on Book.GenreId equals Genre.Id
                orderby Genre.Name
                select new GenreBookViewModel() { Genre = Genre, Book = Book };

            return genresBooks;
        }

        public static IEnumerable<ReaderBookInfoViewModel> ReadersRentedTime()
        {
            var readersTime =
                from Reader in Data.Readers
                join RentedBook in Data.RentedBooks on Reader.Id equals RentedBook.ReaderId
                join Book in Data.Books on RentedBook.BookId equals Book.Id
                orderby RentedBook.ReturnDate.Subtract(RentedBook.IssueDate)
                select new ReaderBookInfoViewModel() 
                {
                    Reader = Reader, 
                    Book = Book, 
                    IssueDate = RentedBook.IssueDate, 
                    ReturnDate = RentedBook.ReturnDate 
                };

            return readersTime;
        }

        public static IEnumerable<GenreBookViewModel> HorrorandDetectiveBooks()
        {
            var horrorAndDetective =
                from Book in Data.Books
                join Genre in Data.Genres on Book.GenreId equals Genre.Id
                where (Genre.Name == "Horror" || Genre.Name == "Detective")
                orderby Genre.Name
                select new GenreBookViewModel() { Book = Book, Genre = Genre};

            return horrorAndDetective;
        }

        public static IEnumerable<AuthorBookViewModel> BooksAuthorWithS()
        {
            var booksAuthorWithS =
                from Book in Data.Books
                join Author in Data.Authors on Book.AuthorId equals Author.Id
                where Author.Name.StartsWith("S")
                orderby Author.Name
                select new AuthorBookViewModel() { Book = Book, Author = Author };

            return booksAuthorWithS;
        }

        public static IEnumerable<AuthorBookViewModel> KingsBookPriceLower45()
        {
            var kingsBookPriceLower = Data.Books.Join(Data.Authors, 
                                                      Book => Book.AuthorId, 
                                                      Author => Author.Id, 
                                                      (Book, Author) => new { Book, Author })
                .Where(Book => Book.Author.Name == "Stephen King" && Book.Book.Deposit < 45)
                .Select(i => new AuthorBookViewModel() { Author = i.Author, Book = i.Book});

            return kingsBookPriceLower;
        }

        public static IEnumerable<Book> BookPriceForWeek()
        {
            var priceForWeek =
                from Book in Data.Books
                orderby (Book.RentPrice * 7)
                select Book;

            return priceForWeek;
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

        public static IEnumerable<Author> AllAuthors()
        {
            var all = Data.Authors.Concat(Data.ConcatAuthors);

            return all;
        }

        public static Dictionary<string, IEnumerable <Book>> BooksByGenre()
        {
            var booksGenres =
                from Book in Data.Books
                join Genre in Data.Genres on Book.GenreId equals Genre.Id
                group Book by Genre.Name into models
                select models;

            return booksGenres.ToDictionary(i => i.Key, j => j.Select(b => b));
        }

        public static Dictionary<string, IEnumerable<Book>> BooksByAuthor()
        {
            var booksAuthor = Data.Books.Join(Data.Authors, i => i.AuthorId, a => a.Id, (Book, Author) => new { Book, Author }).GroupBy(i => i.Author.Name);


            return booksAuthor.ToDictionary(i => i.Key, j => j.Select(a => a.Book));

        }

    }
}
