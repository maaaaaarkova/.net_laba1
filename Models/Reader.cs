using System;
using System.Collections.Generic;
using System.Text;
using laba1.Models.Enum;

namespace laba1.Models
{
    public class Reader
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Category Category { get; set; }
    }

}
