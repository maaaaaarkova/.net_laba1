using System;
using System.Collections.Generic;
using System.Text;
using laba1.Models;
using System.Linq;

namespace laba1
{
    public static class GetInfo
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

        public static void GetBooksInfo(List<(Genre Genre, Author Author, Book Book)>list)
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

        //public static void GetSortedAuthors()
        //{

        //    foreach (var authorInfo in 
                
        //        )
        //    {
        //        Console.WriteLine(authorInfo.Name);
        //    }
        //}
}
}
