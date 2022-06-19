using System;
using System.Collections.Generic;
using System.Text;
using laba1.Models;

namespace laba1
{
    public class ReaderBookInfoViewModel
    {
        public Reader Reader { get; set; }
        public Book Book { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
