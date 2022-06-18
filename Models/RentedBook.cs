using System;
using System.Collections.Generic;
using System.Text;

namespace laba1.Models
{
    public class RentedBook
    {
        public int ReaderId { get; set; }
        public int BookId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
