using System;
using System.Collections.Generic;
using System.Text;
using laba1.Models;
using System.Linq;

namespace laba1
{
    class Queries
    {
        public List<Reader> Readers { get; set; }
        public void ReadersInfo()
        {
            foreach (var readerInfo in (from Reader in Readers select Reader))
            {
                Console.WriteLine(readerInfo.LastName + "\n" + readerInfo.Name + "\n" + readerInfo.Patronymic + "\n" + readerInfo.PhoneNumber + "\n" + readerInfo.Address);
                Console.WriteLine("\n");
            }
        }

        public List<Book> Books { get; set; }
        public void BooksInfo()
        {
            var booksInfo =
                from Book in Books
                join Author in Authors on Book.AuthorId equals Author.Id
                join Genre in Genres on Book.GenreId equals Genre.Id
                select new { Book, Author, Genre };
            foreach(var bookInfo in booksInfo)
            {
                Console.WriteLine( bookInfo.Book.Name + "\n" + bookInfo.Author.Name + "\n" + bookInfo.Genre.Name + "\n" + bookInfo.Book.Deposit + "\n" + bookInfo.Book.RentPrice);
                Console.WriteLine("\n");
            }
        }

        public List<Author> Authors { get; set; }
        public void AuthorsInfo()
        {
            var authorsInfo =
                from Author in Authors
                orderby Author.Name
                select Author;

            foreach(var authorInfo in authorsInfo)
            {
                Console.WriteLine(authorInfo.Name);
            }
        }
        public List<Genre> Genres { get; set; }
        public List<RentedBook> RentedBooks { get; set; }


    }
}
