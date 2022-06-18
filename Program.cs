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

            var query = new Queries()
            {
                Readers = Data.Readers,
                Books = Data.Books,
                Genres = Data.Genres,
                Authors = Data.Authors,
                RentedBooks = Data.RentedBooks
            };

            query.ReadersInfo();
            query.BooksInfo();
            query.AuthorsInfo();
        }
    } 
}
