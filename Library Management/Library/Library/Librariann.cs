using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
  class Librariann
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
