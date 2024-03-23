using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public int BookID { get; set; }

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Publisher { get; set; }
        public string PublicationDate { get; set; }
        public int NumberOfPage { get; set; }
        public string Language { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
        public int LibrarianID { get; set; }
        public Librariann librarian { get; set; }

        public int AuthorrID { get; set; }
        public Authorr authorr { get; set; }
    }
}
