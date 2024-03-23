using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   class Libraryy
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public ICollection<Account> accounts { get; set; }
        public ICollection<BookItem> bookItems { get; set; }
        public ICollection<Catalog> catalogs { get; set; }
    }
}
