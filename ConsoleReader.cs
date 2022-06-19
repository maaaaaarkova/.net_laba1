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

        public static void GetGenresGroupBooks(List<(Genre Genre, Book Book)> list)
        {
            foreach (var genresBooks in list)
            {

                Console.WriteLine(genresBooks.Book.Name);
                Console.WriteLine(genresBooks.Genre.Name);
                Console.WriteLine("\n");
            }
        }
        public static void GetReadersRentedTime(List<(Reader Reader, Book Book, RentedBook RentedBook)> list)
        {
            
            foreach (var readersTime in list)
            {
                Console.WriteLine(readersTime.Reader.LastName);
                Console.WriteLine(readersTime.Reader.Name);
                Console.WriteLine(readersTime.Reader.Patronymic);
                Console.WriteLine(readersTime.Book.Name);
                TimeSpan rent = readersTime.RentedBook.ReturnDate.Subtract(readersTime.RentedBook.IssueDate);
                Console.WriteLine(String.Format("{0:dd}", rent));
                Console.WriteLine("\n");
            }
        }

        public static void GetHorrorandDetectiveBooks(List<(Genre Genre, Book Book)> list)
        {
            foreach (var HorrorandDetectiveBooks in list)
            {
                Console.WriteLine(HorrorandDetectiveBooks.Book.Name);
                Console.WriteLine(HorrorandDetectiveBooks.Genre.Name);
                Console.WriteLine("\n");
            }
        }

        public static void GetBooksAuthorWithS(List<(Author Author, Book Book)> list)
        {
            foreach (var booksAuthorWithS in list)
            {
                Console.WriteLine(booksAuthorWithS.Book.Name);
                Console.WriteLine(booksAuthorWithS.Author.Name);
                Console.WriteLine("\n");
            }
        }

        public static void GetKingsBookPriceLower45(List<(Author Author, Book Book)> list)
        {
            foreach (var kingsBookPriceLower in list)
            {
                Console.WriteLine(kingsBookPriceLower.Book.Name);
                Console.WriteLine(kingsBookPriceLower.Author.Name);
                Console.WriteLine(kingsBookPriceLower.Book.Deposit);
                Console.WriteLine("\n");
            }
        }

        public static void GetBookPriceForWeek(IEnumerable<Book> list)
        {
            foreach (var priceForWeek in list)
            {
                Console.WriteLine(priceForWeek.Name);
                Console.WriteLine(priceForWeek.RentPrice);
                Console.WriteLine(priceForWeek.RentPrice * 7);
                Console.WriteLine("\n");
            }
        }

    }
}
