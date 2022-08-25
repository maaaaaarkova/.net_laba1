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
            var queries = new Queries();
            var consoleReader = new ConsoleReader();

            var readerInfo = queries.ReadersInfo();
            consoleReader.GetReadersInfo(readerInfo);

            Console.WriteLine(new string('_', 60));

            var bookInfo = queries.BooksInfo();
            consoleReader.GetBooksInfo(bookInfo);

            Console.WriteLine(new string('_', 60));

            var authorSorted = queries.AuthorsSortedInfo();
            consoleReader.GetSortedAuthors(authorSorted);

            Console.WriteLine(new string('_', 60));

            var priceOver40 = queries.BooksPriceOver40();
            consoleReader.GetBooksPriceOver40(priceOver40);

            Console.WriteLine(new string('_', 60));

            var nameStartsWithO = queries.ReaderNameStartsWithOInfo();
            consoleReader.GetReadersNameStartsWithO(nameStartsWithO);

            Console.WriteLine(new string('_', 60));

            var stephensBooks = queries.StephenKingBooks();
            consoleReader.GetStephenKingBooks(stephensBooks);

            Console.WriteLine(new string('_', 60));

            var sortedCollege = queries.SortedCollegeStudents();
            consoleReader.GetSortedCollegeStudents(sortedCollege);

            Console.WriteLine(new string('_', 60));

            var readersRentedBooks = queries.ReadersRentedBooks();
            consoleReader.GetReadersRentedBooks(readersRentedBooks);

            Console.WriteLine(new string('_', 60));

            var genresBooks = queries.GenresGroupBooks();
            consoleReader.GetGenresGroupBooks(genresBooks);

            Console.WriteLine(new string('_', 60));

            var rentTime = queries.ReadersRentedTime();
            consoleReader.GetReadersRentedTime(rentTime);

            Console.WriteLine(new string('_', 60));

            var horrorAndDetective = queries.HorrorandDetectiveBooks();
            consoleReader.GetHorrorandDetectiveBooks(horrorAndDetective);

            Console.WriteLine(new string('_', 60));

            var booksAuthorWithS = queries.BooksAuthorWithS();
            consoleReader.GetBooksAuthorWithS(booksAuthorWithS);

            Console.WriteLine(new string('_', 60));

            var kingsBookPrice = queries.KingsBookPriceLower45();
            consoleReader.GetKingsBookPriceLower45(kingsBookPrice);

            Console.WriteLine(new string('_', 60));

            var weekPrice = queries.BookPriceForWeek();
            consoleReader.GetBookPriceForWeek(weekPrice);

            Console.WriteLine(new string('_', 60));

            var booksPriceHigher40 = queries.BooksPriceHigher40();
            Console.WriteLine(booksPriceHigher40);

            Console.WriteLine(new string('_', 60));

            var allAuthors = queries.AllAuthors();
            consoleReader.GetAllAuthors(allAuthors);

            Console.WriteLine(new string('_', 60));

            var booksByGenre = queries.BooksByGenre();
            consoleReader.GetBooksByGenre(booksByGenre);

            Console.WriteLine(new string('_', 60));

            var booksByAuthor = queries.BooksByAuthor();
            consoleReader.GetBooksByAuthor(booksByAuthor);
        }
    } 
}
