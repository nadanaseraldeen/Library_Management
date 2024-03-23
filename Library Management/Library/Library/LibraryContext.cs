using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class LibraryContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Authorr> Authorrs { get; set; }
        public DbSet<Book> Books { get; set; }
       public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookItem> BookItems { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Librariann> Librarianns { get; set; }
        public DbSet<Libraryy> Librariees { get; set; }
        public DbSet<Patronn> Patronns { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8JPSEDV\SQLEXPRESS;Database=LibraryManagement5;Trusted_Connection=True;");
        }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patronn>()
                .HasOne<Account>(s => s.account)
                .WithOne(ad => ad.Patron)
                .HasForeignKey<Account>(ad => ad.PatronID);
         
        }
        


    }
}
