using System;
using System.Collections.Generic;
using System.Text;
using laba1.Models;
using System.Linq;

namespace laba1
{
    public static class ConsoleReader
    {
        public static void GetReadersInfo(IEnumerable<Reader> list)
        {
            foreach (var readerInfo in list)
            {
                Console.WriteLine(readerInfo.LastName);
                Console.WriteLine(readerInfo.Name);
                Console.WriteLine(readerInfo.Patronymic);
                Console.WriteLine(readerInfo.PhoneNumber);
                Console.WriteLine(readerInfo.Address);
                Console.WriteLine("\n");
            }
        }

        public static void GetBooksInfo(List<(Genre Genre, Author Author, Book Book)> list)
        {
            foreach (var bookInfo in list)
            {
                Console.WriteLine(bookInfo.Book.Name);
                Console.WriteLine(bookInfo.Author.Name);
                Console.WriteLine(bookInfo.Genre.Name);
                Console.WriteLine(bookInfo.Book.Deposit);
                Console.WriteLine(bookInfo.Book.RentPrice);
                Console.WriteLine("\n");
            }
        }

        public static void GetSortedAuthors(IEnumerable<Author> list)
        {
            foreach (var authorInfo in list)
            {
                Console.WriteLine(authorInfo.Name);
                Console.WriteLine("\n");
            }
        }

        public static void GetBooksPriceOver40(List<(Genre Genre, Author Author, Book Book)> list)
        {
            foreach (var bookPriceOver in list)
            {
                Console.WriteLine(bookPriceOver.Book.Name);
                Console.WriteLine(bookPriceOver.Author.Name);
                Console.WriteLine(bookPriceOver.Genre.Name);
                Console.WriteLine(bookPriceOver.Book.Deposit);
                Console.WriteLine("\n");
            }
        }

        public static void GetReadersNameStartsWithO(IEnumerable<Reader> list)
        {
            foreach (var nameStartsWithO in list)
            {
                Console.WriteLine(nameStartsWithO.LastName);
                Console.WriteLine(nameStartsWithO.Name);
                Console.WriteLine(nameStartsWithO.Patronymic);
                Console.WriteLine(nameStartsWithO.PhoneNumber);
                Console.WriteLine(nameStartsWithO.Address);
                Console.WriteLine("\n");
            }
        }

        public static void GetStephenKingBooks(List<(Author Author, Book Book)> list)
        {
            foreach (var kingsBooks in list)
            {
                Console.WriteLine(kingsBooks.Book.Name);
                Console.WriteLine(kingsBooks.Author.Name);
                Console.WriteLine("\n");
            }
        }

        public static void GetSortedCollegeStudents(IEnumerable<Reader> list)
        {
            foreach (var sortedCollegeStudent in list)
            {
                Console.WriteLine(sortedCollegeStudent.LastName);
                Console.WriteLine(sortedCollegeStudent.Name);
                Console.WriteLine(sortedCollegeStudent.Patronymic);
                Console.WriteLine(sortedCollegeStudent.PhoneNumber);
                Console.WriteLine(sortedCollegeStudent.Address);
                Console.WriteLine(sortedCollegeStudent.Category);
                Console.WriteLine("\n");
            }
        }

        public static void GetReadersRentedBooks(List<(Reader Reader, Book Book)> list)
        {
            foreach (var readersBooks in list)
            {
                Console.WriteLine(readersBooks.Reader.LastName);
                Console.WriteLine(readersBooks.Reader.Name);
                Console.WriteLine(readersBooks.Reader.Patronymic);
                Console.WriteLine(readersBooks.Book.Name);
                Console.WriteLine("\n");
            }
        }
    }
}
