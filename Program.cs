using System;
using System.Collections.Generic;
using System.Text;
using laba1.Models;
using System.Linq;


namespace laba1
{
    public class Program
    {
        public static void Main()
        {

            var readerInfo = Queries.ReadersInfo();
            ConsoleReader.GetReadersInfo(readerInfo);

            var bookInfo = Queries.BooksInfo();
            ConsoleReader.GetBooksInfo(bookInfo);

            var authorSorted = Queries.AuthorsSortedInfo();
            ConsoleReader.GetSortedAuthors(authorSorted);

            var priceOver40 = Queries.BooksPriceOver40();
            ConsoleReader.GetBooksPriceOver40(priceOver40);

            var nameStartsWithO = Queries.ReaderNameStartsWithOInfo();
            ConsoleReader.GetReadersNameStartsWithO(nameStartsWithO);

            var stephensBooks = Queries.StephenKingBooks();
            ConsoleReader.GetStephenKingBooks(stephensBooks);

            var sortedCollege = Queries.SortedCollegeStudents();
            ConsoleReader.GetSortedCollegeStudents(sortedCollege);

            var readersRentedBooks = Queries.ReadersRentedBooks();
            ConsoleReader.GetReadersRentedBooks(readersRentedBooks);
        }
    } 
}
