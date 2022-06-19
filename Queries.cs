using System;
using System.Collections.Generic;
using System.Text;
using laba1.Models;
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

        public static void AuthorsSortedInfo()
        {
            var authorsInfo =
                from Author in Data.Authors
                orderby Author.Name
                select Author;

        }

        public static Dictionary<string, (Author Author, Book Book)> BooksPriceOver40()
        {
            var bookPriceOver =
                from Book in Data.Books
                join Author in Data.Authors on Book.AuthorId equals Author.Id
                join Genre in Data.Genres on Book.GenreId equals Genre.Id
                where Book.Deposit >= 40
                select new { Book, Author, Genre };

            return bookPriceOver.ToDictionary(i => i.Genre.Name, i => (Author: i.Author, Book: i.Book));

        }


    }
}
