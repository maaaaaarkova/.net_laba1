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

            Console.WriteLine(new string('_', 60));

            var bookInfo = Queries.BooksInfo();
            ConsoleReader.GetBooksInfo(bookInfo);

            Console.WriteLine(new string('_', 60));

            var authorSorted = Queries.AuthorsSortedInfo();
            ConsoleReader.GetSortedAuthors(authorSorted);

            Console.WriteLine(new string('_', 60));

            var priceOver40 = Queries.BooksPriceOver40();
            ConsoleReader.GetBooksPriceOver40(priceOver40);

            Console.WriteLine(new string('_', 60));

            var nameStartsWithO = Queries.ReaderNameStartsWithOInfo();
            ConsoleReader.GetReadersNameStartsWithO(nameStartsWithO);

            Console.WriteLine(new string('_', 60));

            var stephensBooks = Queries.StephenKingBooks();
            ConsoleReader.GetStephenKingBooks(stephensBooks);

            Console.WriteLine(new string('_', 60));

            var sortedCollege = Queries.SortedCollegeStudents();
            ConsoleReader.GetSortedCollegeStudents(sortedCollege);

            Console.WriteLine(new string('_', 60));

            var readersRentedBooks = Queries.ReadersRentedBooks();
            ConsoleReader.GetReadersRentedBooks(readersRentedBooks);

            Console.WriteLine(new string('_', 60));

            var genresBooks = Queries.GenresGroupBooks();
            ConsoleReader.GetGenresGroupBooks(genresBooks);

            Console.WriteLine(new string('_', 60));

            var rentTime = Queries.ReadersRentedTime();
            ConsoleReader.GetReadersRentedTime(rentTime);

            Console.WriteLine(new string('_', 60));

            var horrorAndDetective = Queries.HorrorandDetectiveBooks();
            ConsoleReader.GetHorrorandDetectiveBooks(horrorAndDetective);

            Console.WriteLine(new string('_', 60));

            var booksAuthorWithS = Queries.BooksAuthorWithS();
            ConsoleReader.GetBooksAuthorWithS(booksAuthorWithS);

            Console.WriteLine(new string('_', 60));

            var kingsBookPrice = Queries.KingsBookPriceLower45();
            ConsoleReader.GetKingsBookPriceLower45(kingsBookPrice);

            Console.WriteLine(new string('_', 60));

            var weekPrice = Queries.BookPriceForWeek();
            ConsoleReader.GetBookPriceForWeek(weekPrice);

            Console.WriteLine(new string('_', 60));

            var booksPriceHigher40 = Queries.BooksPriceHigher40();
            Console.WriteLine(booksPriceHigher40);

            Console.WriteLine(new string('_', 60));

            var allAuthors = Queries.AllAuthors();
            ConsoleReader.GetAllAuthors(allAuthors);

            Console.WriteLine(new string('_', 60));

            var booksByGenre = Queries.BooksByGenre();
            ConsoleReader.GetBooksByGenre(booksByGenre);

            Console.WriteLine(new string('_', 60));

            var booksByAuthor = Queries.BooksByAuthor();
            ConsoleReader.GetBooksByAuthor(booksByAuthor);
        }
    } 
}
