using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   class BookItem : Book
    {
        public string barcode { get; set; }
        public int tag { get; set; }
        public string isReferenceOnly { get; set; }
        public int CatalogID { get; set; }
        public Catalog catalog { get; set; }
        public int? AccountID { get; set; }
        public Account account { get; set; }
        public int LibraryID { get; set; }
        public Libraryy library { get; set; }
    }
}
