using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        private int _no;
        public int No { get=>_no;}

        public Book()
        {
            _no++;
        }
    }
}
