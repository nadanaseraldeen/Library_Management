using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Library
{
   class BookOperation : Search
    {
        public enum AccountState { active, frozen, closed };
      


        LibraryContext ctx = new LibraryContext();

        public void createBook(Book b)
        {
            ctx.Books.Add(b);
            ctx.SaveChanges();
        }


        public string SearchBook()
        {
            throw new NotImplementedException();
        }




    }
}
