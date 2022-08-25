using System;
using System.Collections.Generic;
using System.Text;
using laba1.Models;
using laba1.Models.Enum;
using System.Linq;

namespace laba1
{
    public class Queries
    {
        private readonly Data _data;
        public Queries()
        {
            _data = new Data();
        }

        public  IEnumerable<Reader> ReadersInfo()
        {
            var readerInfo =
                from Reader in _data.Readers
                select Reader;

            return readerInfo;
        }

        public  IEnumerable<BooksInfoViewModel> BooksInfo()
        {
            var booksInfo =
                from Book in _data.Books
                join Author in _data.Authors on Book.AuthorId equals Author.Id
                join Genre in _data.Genres on Book.GenreId equals Genre.Id
                select new BooksInfoViewModel() { Book = Book, Author = Author, Genre = Genre };

            return booksInfo;       
        }

        public  IEnumerable<Author> AuthorsSortedInfo()
        {
            var authorsSortedInfo =
                from Author in _data.Authors
                orderby Author.Name
                select Author;

            return authorsSortedInfo;
        }

        public  IEnumerable<BooksInfoViewModel> BooksPriceOver40()
        {
            var bookPriceOver =
                from Book in _data.Books
                join Author in _data.Authors on Book.AuthorId equals Author.Id
                join Genre in _data.Genres on Book.GenreId equals Genre.Id
                where Book.Deposit >= 40
                select new BooksInfoViewModel() { Book = Book, Author = Author, Genre = Genre };

            return bookPriceOver;

        }

        public  IEnumerable<Reader> ReaderNameStartsWithOInfo()
        {
            var nameStartsWithO = _data.Readers.Where(i => i.Name.StartsWith("O"));

            return nameStartsWithO;
        }

        public  IEnumerable<AuthorBookViewModel> StephenKingBooks()
        {
            var kingsBooks =
                from Book in _data.Books
                join Author in _data.Authors on Book.AuthorId equals Author.Id
                where Author.Name.Equals("Stephen King", StringComparison.OrdinalIgnoreCase)
                select new AuthorBookViewModel() { Book = Book, Author = Author };

            return kingsBooks;
        }


        public  IEnumerable<Reader> SortedCollegeStudents()
        {
            var sortedCollegeStudent = _data.Readers.Where(i => i.Category == Category.CollegeStudent).OrderBy(i => i.LastName);

            return sortedCollegeStudent;
        }

        public  IEnumerable<ReaderBookViewModel> ReadersRentedBooks()
        {
            var readersBooks =
                from Reader in _data.Readers
                join RentedBook in _data.RentedBooks on Reader.Id equals RentedBook.ReaderId
                join Book in _data.Books on RentedBook.BookId equals Book.Id
                select new ReaderBookViewModel() { Reader = Reader, Book = Book };

            return readersBooks;
        }

        public  IEnumerable<GenreBookViewModel> GenresGroupBooks()
        {
            var genresBooks =
                from Book in _data.Books
                join Genre in _data.Genres on Book.GenreId equals Genre.Id
                orderby Genre.Name
                select new GenreBookViewModel() { Genre = Genre, Book = Book };

            return genresBooks;
        }

        public  IEnumerable<ReaderBookInfoViewModel> ReadersRentedTime()
        {
            var readersTime =
                from Reader in _data.Readers
                join RentedBook in _data.RentedBooks on Reader.Id equals RentedBook.ReaderId
                join Book in _data.Books on RentedBook.BookId equals Book.Id
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

        public IEnumerable<GenreBookViewModel> HorrorandDetectiveBooks()
        {
            var horrorAndDetective =
                from Book in _data.Books
                join Genre in _data.Genres on Book.GenreId equals Genre.Id
                where (Genre.Name.Equals("Horror", StringComparison.OrdinalIgnoreCase) || 
                       Genre.Name.Equals("Detective", StringComparison.OrdinalIgnoreCase))
                orderby Genre.Name
                select new GenreBookViewModel() { Book = Book, Genre = Genre};

            return horrorAndDetective;
        }

        public IEnumerable<AuthorBookViewModel> BooksAuthorWithS()
        {
            var booksAuthorWithS =
                from Book in _data.Books
                join Author in _data.Authors on Book.AuthorId equals Author.Id
                where Author.Name.StartsWith("S")
                orderby Author.Name
                select new AuthorBookViewModel() { Book = Book, Author = Author };

            return booksAuthorWithS;
        }

        public  IEnumerable<AuthorBookViewModel> KingsBookPriceLower45()
        {
            var kingsBookPriceLower = _data.Books.Join(_data.Authors, 
                                                      Book => Book.AuthorId, 
                                                      Author => Author.Id, 
                                                      (Book, Author) => new { Book, Author })
                .Where(Book => Book.Author.Name.Equals("Stephen King", StringComparison.OrdinalIgnoreCase) && Book.Book.Deposit < 45)
                .Select(i => new AuthorBookViewModel() { Author = i.Author, Book = i.Book});

            return kingsBookPriceLower;
        }

        public  IEnumerable<Book> BookPriceForWeek()
        {
            var priceForWeek =
                from Book in _data.Books
                orderby (Book.RentPrice * 7)
                select Book;

            return priceForWeek;
        }

        public  int BooksPriceHigher40()
        {
            var booksPriceHigher40 =
                (from Book in _data.Books
                join Author in _data.Authors on Book.AuthorId equals Author.Id
                where !Author.Name.Equals("Stephen King", StringComparison.OrdinalIgnoreCase) && Book.Deposit > 40
                orderby Book.Deposit
                select new { Book, Author }).Count();

            return booksPriceHigher40;
        }

        public  IEnumerable<Author> AllAuthors()
        {
            var all = _data.Authors.Concat(_data.UkrainianAuthors);

            return all;
        }

        public  Dictionary<string, IEnumerable <Book>> BooksByGenre()
        {
            var booksGenres =
                from Book in _data.Books
                join Genre in _data.Genres on Book.GenreId equals Genre.Id
                group Book by Genre.Name into models
                select models;

            return booksGenres.ToDictionary(i => i.Key, j => j.Select(b => b));
        }

        public  Dictionary<string, IEnumerable<Book>> BooksByAuthor()
        {
            var booksAuthor = _data.Books.Join(_data.Authors, i => i.AuthorId, a => a.Id, (Book, Author) => new { Book, Author }).GroupBy(i => i.Author.Name);


            return booksAuthor.ToDictionary(i => i.Key, j => j.Select(a => a.Book));

        }

    }
}
