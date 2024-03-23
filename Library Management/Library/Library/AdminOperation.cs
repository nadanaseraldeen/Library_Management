using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class AdminOperation
    {
        LibraryContext ctx = new LibraryContext();
        public void CreateLibrarian(Librariann l)
        {
          
                ctx.Librarianns.Add(l);
                ctx.SaveChanges();
           
         

        }

        public int CreatePatron(Patronn p)
        {
            ctx.Add<Patronn>(p);
            ctx.SaveChanges();
            return p.ID;
        }

        public void CreateLibrary(Libraryy li)
        {
           
                ctx.Librariees.Add(li);
                ctx.SaveChanges();
         

        }

        public void CreateCatalog(Catalog c)
        {
            ctx.Catalogs.Add(c);
            ctx.SaveChanges();

        }
    }
}
