using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   class Account
    {
        public int ID { get; set; }
        public string History { get; set; }
        public DateTime Opened { get; set; }
        public string State { get; set; }
        public int LibraryID { get; set; }
        public Libraryy Library { get; set; }

        public ICollection<BookItem> BookItems { get; set; }
        public int PatronID { get; set; }
        public Patronn Patron { get; set; }
    }
}
