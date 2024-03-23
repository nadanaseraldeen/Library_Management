using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   class Catalog 
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<BookItem> BookItems { get; set; }

        public int LibraryID { get; set; }
        public Libraryy library { get; set; }

    }
}
