using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLMS.Data_Structures
{
    public class Book
    {
        private static int nextid = 1001;
        public  int Id ;
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
            Id = nextid;
            nextid = nextid + 1;
        }
    }
}
