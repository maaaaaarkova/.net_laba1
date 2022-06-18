using System;
using System.Collections.Generic;
using System.Text;

namespace laba1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public decimal Deposit { get; set; }
        public decimal RentPrice { get; set; }
    }
}
