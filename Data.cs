using System;
using System.Collections.Generic;
using System.Text;
using laba1.Models;
using laba1.Models.Enum;

namespace laba1.Models
{
    public class Data
    {
        public static List<Reader> Readers =>
            new List<Reader>
            {
                new Reader()
                {
                    Id = 1,
                    LastName = "Ivanov",
                    Name = "Ivan",
                    Patronymic = "Ivanovych",
                    Address = "vul. Persha 98",
                    PhoneNumber = "380989473981",
                    Category = Category.SchoolStudent
                },

                new Reader()
                {  
                    Id = 2,
                    LastName = "Petrov",
                    Name = "Petro",
                    Patronymic = "Petrovych",
                    Address = "vul. Druga 13",
                    PhoneNumber = "380974639873",
                    Category = Category.Preschooler
                },

                new Reader()
                {
                    Id = 3,
                    LastName = "Tarasov",
                    Name = "Taras",
                    Patronymic = "Tarasovych",
                    Address = "vul. Tretya 172",
                    PhoneNumber = "380669832716",
                    Category = Category.Preschooler
                },

                new Reader()
                {
                    Id = 4,
                    LastName = "Danylov",
                    Name = "Danylo",
                    Patronymic = "Danylovych",
                    Address = "vul. Chetverta 93",
                    PhoneNumber = "380671298362",
                    Category = Category.Adult
                },

                new Reader()
                {
                    Id = 5,
                    LastName = "Maksymov",
                    Name = "Maksym",
                    Patronymic = "Maksymovych",
                    Address = "vul. Pyata 72",
                    PhoneNumber = "380932876229",
                    Category = Category.Adult
                },

                new Reader()
                {
                    Id = 6,
                    LastName = "Oleksandrov",
                    Name = "Oleksandr",
                    Patronymic = "Oleksandrovych",
                    Address = "vul. Shosta 91",
                    PhoneNumber = "380971286424",
                    Category = Category.CollegeStudent
                },

                new Reader()
                {
                    Id = 7,
                    LastName = "Oleksiiv",
                    Name = "Oleksiy",
                    Patronymic = "Oleksiyovych",
                    Address = "vul. Syoma 221",
                    PhoneNumber = "380672389748",
                    Category = Category.CollegeStudent
                },

                new Reader()
                {
                    Id = 8,
                    LastName = "Mykolayiv",
                    Name = "Mykola",
                    Patronymic = "Mykolayovych",
                    Address = "vul. Vosma 351",
                    PhoneNumber = "380661876321",
                    Category = Category.CollegeStudent
                },

            };

        public static List<Genre> Genres =>
            new List<Genre>
            {
                new Genre
                {
                    Id = 1,
                    Name = "Fantasy"
                },

                new Genre
                {
                    Id = 2,
                    Name = "Detective"
                },

                new Genre
                {
                    Id = 3,
                    Name = "Horror"
                },

                new Genre
                {
                    Id = 4,
                    Name = "Romance"
                },

                new Genre
                {
                    Id = 5,
                    Name = "Science Fiction"
                },

                new Genre
                {
                    Id = 6,
                    Name = "Adventure"
                },

            };

        public static List<Author> Authors =>
            new List<Author>
            {
                new Author
                {
                    Id = 1,
                    Name = "Madeline Miller"
                },

                new Author
                {
                    Id = 2,
                    Name = "Stephen King",
                },

                new Author
                {
                    Id = 3,
                    Name = "Jasmine Guillory",
                },

                new Author
                {
                    Id = 4,
                    Name = "Margaret Atwood",
                },

                new Author
                {
                    Id = 5,
                    Name = "George Orwell",
                },

                new Author
                {
                    Id = 6,
                    Name = "Sir Arthur Conan Doyle",
                },

                new Author
                {
                    Id = 7,
                    Name = "Jane Austen",
                },

            };

        public static List<Author> ConcatAuthors =>
           new List<Author>
           {
                new Author
                {
                    Id = 1,
                    Name = "Taras Shevchenko",
                },

                new Author
                {
                    Id = 2,
                    Name = "Ivan Franko",
                },

                new Author
                {
                    Id = 3,
                    Name = "Olena Pchilka",
                },

                new Author
                {
                    Id = 4,
                    Name = "Mykola Hvyloviy",
                },

           };

        public static List<Book> Books =>
            new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Name = "Circe",
                    AuthorId = 1,
                    GenreId = 1,
                    Deposit = 50,
                    RentPrice = 10
                },

                new Book
                {
                    Id = 2,
                    Name = "IT",
                    AuthorId = 2,
                    GenreId = 3,
                    Deposit = 30,
                    RentPrice = 10
                },

                new Book
                {
                    Id = 3,
                    Name = "Pride and Prejudice",
                    AuthorId = 7,
                    GenreId = 4,
                    Deposit = 70,
                    RentPrice = 12
                },

                new Book
                {
                    Id = 4,
                    Name = "1984",
                    AuthorId = 5,
                    GenreId = 5,
                    Deposit = 30,
                    RentPrice = 7
                },

                new Book
                {
                    Id = 5,
                    Name = "The Testaments",
                    AuthorId = 4,
                    GenreId = 5,
                    Deposit = 30,
                    RentPrice = 9
                },

                new Book
                {
                    Id = 6,
                    Name = "The Adventures of Sherlock Holmes",
                    AuthorId = 6,
                    GenreId = 2,
                    Deposit = 70,
                    RentPrice = 15
                },

                new Book
                {
                    Id = 7,
                    Name = "The Stand",
                    AuthorId = 2,
                    GenreId = 3,
                    Deposit = 50,
                    RentPrice = 13
                },

                new Book
                {
                    Id = 8,
                    Name = "If it bleeds",
                    AuthorId = 2,
                    GenreId = 3,
                    Deposit = 45,
                    RentPrice = 12
                },

                new Book
                {
                    Id = 9,
                    Name = "The Mist",
                    AuthorId = 2,
                    GenreId = 3,
                    Deposit = 35,
                    RentPrice = 8
                },


            };

        public static List<RentedBook> RentedBooks =>
            new List<RentedBook>
            {
                new RentedBook
                {
                    ReaderId = 2,
                    BookId = 4,
                    IssueDate = new DateTime(2021, 7, 20),
                    ReturnDate = new DateTime(2021, 8, 01)
                },

                new RentedBook
                {
                    ReaderId = 2,
                    BookId = 6,
                    IssueDate = new DateTime(2021, 10, 04),
                    ReturnDate = new DateTime(2021, 10, 20)
                },

                new RentedBook
                {
                    ReaderId = 1,
                    BookId = 4,
                    IssueDate = new DateTime(2022, 5, 30),
                    ReturnDate = new DateTime(2022, 6, 21)
                },

                new RentedBook
                {
                    ReaderId = 5,
                    BookId = 1,
                    IssueDate = new DateTime(2021, 6, 20),
                    ReturnDate = new DateTime(2021, 8, 02)
                },

                new RentedBook
                {
                    ReaderId = 3,
                    BookId = 2,
                    IssueDate = new DateTime(2021, 1, 02),
                    ReturnDate = new DateTime(2021, 1, 21)
                },

                new RentedBook
                {
                    ReaderId = 4,
                    BookId = 4,
                    IssueDate = new DateTime(2021, 1, 03),
                    ReturnDate = new DateTime(2021, 1, 13)
                },
             
                new RentedBook
                {
                    ReaderId = 7,
                    BookId = 6,
                    IssueDate = new DateTime(2021, 11, 17),
                    ReturnDate = new DateTime(2021, 12, 13)
                },

                new RentedBook
                {
                    ReaderId = 7,
                    BookId = 1,
                    IssueDate = new DateTime(2021, 10, 09),
                    ReturnDate = new DateTime(2021, 10, 31)
                },

                new RentedBook
                {
                    ReaderId = 5,
                    BookId = 3,
                    IssueDate = new DateTime(2022, 3, 19),
                    ReturnDate = new DateTime(2022, 4, 05)
                }
            };
    }
}
