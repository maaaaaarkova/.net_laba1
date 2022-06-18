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

            };

        public static List<Genre> Genres =>
            new List<Genre>
            {
                new Genre
                {
                    Id = 1,
                    GenreName = "Fantasy"
                },

                new Genre
                {
                    Id = 2,
                    GenreName = "Detective"
                },

                new Genre
                {
                    Id = 3,
                    GenreName = "Horror"
                },

                new Genre
                {
                    Id = 4,
                    GenreName = "Romance"
                },

                new Genre
                {
                    Id = 5,
                    GenreName = "Science Fiction"
                },

                new Genre
                {
                    Id = 6,
                    GenreName = "Adventure"
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

            };
    }
}
