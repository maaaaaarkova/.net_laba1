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

            Console.WriteLine("___________________________________________________________________________");

            var bookInfo = Queries.BooksInfo();
            ConsoleReader.GetBooksInfo(bookInfo);

            Console.WriteLine("___________________________________________________________________________");

            var authorSorted = Queries.AuthorsSortedInfo();
            ConsoleReader.GetSortedAuthors(authorSorted);

            Console.WriteLine("___________________________________________________________________________");

            var priceOver40 = Queries.BooksPriceOver40();
            ConsoleReader.GetBooksPriceOver40(priceOver40);

            Console.WriteLine("___________________________________________________________________________");

            var nameStartsWithO = Queries.ReaderNameStartsWithOInfo();
            ConsoleReader.GetReadersNameStartsWithO(nameStartsWithO);

            Console.WriteLine("___________________________________________________________________________");

            var stephensBooks = Queries.StephenKingBooks();
            ConsoleReader.GetStephenKingBooks(stephensBooks);

            Console.WriteLine("___________________________________________________________________________");

            var sortedCollege = Queries.SortedCollegeStudents();
            ConsoleReader.GetSortedCollegeStudents(sortedCollege);

            Console.WriteLine("___________________________________________________________________________");

            var readersRentedBooks = Queries.ReadersRentedBooks();
            ConsoleReader.GetReadersRentedBooks(readersRentedBooks);

            Console.WriteLine("___________________________________________________________________________");

            var genresBooks = Queries.GenresGroupBooks();
            ConsoleReader.GetGenresGroupBooks(genresBooks);

            Console.WriteLine("___________________________________________________________________________");

            var rentTime = Queries.ReadersRentedTime();
            ConsoleReader.GetReadersRentedTime(rentTime);

            Console.WriteLine("___________________________________________________________________________");

            var horrorAndDetective = Queries.HorrorandDetectiveBooks();
            ConsoleReader.GetHorrorandDetectiveBooks(horrorAndDetective);

            Console.WriteLine("___________________________________________________________________________");

            var booksAuthorWithS = Queries.BooksAuthorWithS();
            ConsoleReader.GetBooksAuthorWithS(booksAuthorWithS);

            Console.WriteLine("___________________________________________________________________________");

            var kingsBookPrice = Queries.KingsBookPriceLower45();
            ConsoleReader.GetKingsBookPriceLower45(kingsBookPrice);

            Console.WriteLine("___________________________________________________________________________");

            var weekPrice = Queries.BookPriceForWeek();
            ConsoleReader.GetBookPriceForWeek(weekPrice);

            Console.WriteLine("___________________________________________________________________________");

            var booksPriceHigher40 = Queries.BooksPriceHigher40();
            Console.WriteLine(booksPriceHigher40);
        }
    } 
}
