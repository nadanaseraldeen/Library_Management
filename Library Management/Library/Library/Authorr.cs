using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   class Authorr
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
        public ICollection<Book> books { get; set; }

    }
}
