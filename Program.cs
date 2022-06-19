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

            var list = Queries.ReadersInfo();
            GetInfo.GetReadersInfo(list);

            var list1 = Queries.BooksInfo();
            GetInfo.GetBooksInfo(list1);
        }
    } 
}
