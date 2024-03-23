﻿// <auto-generated />
using System;
using Library;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Library.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("History")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LibraryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Opened")
                        .HasColumnType("datetime2");

                    b.Property<int>("PatronID")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("LibraryID");

                    b.HasIndex("PatronID")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Library.Authorr", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Authorrs");
                });

            modelBuilder.Entity("Library.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookID"), 1L, 1);

                    b.Property<int>("AuthorrID")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LibrarianID")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPage")
                        .HasColumnType("int");

                    b.Property<string>("PublicationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.HasIndex("AuthorrID");

                    b.HasIndex("LibrarianID");

                    b.ToTable("Books");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Book");
                });

            modelBuilder.Entity("Library.BookAuthor", b =>
                {
                    b.Property<int>("BookAuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookAuthorID"), 1L, 1);

                    b.Property<int>("AuthorrID")
                        .HasColumnType("int");

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.HasKey("BookAuthorID");

                    b.HasIndex("AuthorrID");

                    b.HasIndex("BookID");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("Library.Catalog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("LibraryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("LibraryID");

                    b.ToTable("Catalogs");
                });

            modelBuilder.Entity("Library.Librariann", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Password")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Librarianns");
                });

            modelBuilder.Entity("Library.Libraryy", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Librariees");
                });

            modelBuilder.Entity("Library.Patronn", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Patronns");
                });

            modelBuilder.Entity("Library.BookItem", b =>
                {
                    b.HasBaseType("Library.Book");

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.Property<int>("CatalogID")
                        .HasColumnType("int");

                    b.Property<int>("LibraryID")
                        .HasColumnType("int");

                    b.Property<string>("barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isReferenceOnly")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tag")
                        .HasColumnType("int");

                    b.HasIndex("AccountID");

                    b.HasIndex("CatalogID");

                    b.HasIndex("LibraryID");

                    b.HasDiscriminator().HasValue("BookItem");
                });

            modelBuilder.Entity("Library.Account", b =>
                {
                    b.HasOne("Library.Libraryy", "Library")
                        .WithMany("accounts")
                        .HasForeignKey("LibraryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Patronn", "Patron")
                        .WithOne("account")
                        .HasForeignKey("Library.Account", "PatronID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Library");

                    b.Navigation("Patron");
                });

            modelBuilder.Entity("Library.Book", b =>
                {
                    b.HasOne("Library.Authorr", "authorr")
                        .WithMany("books")
                        .HasForeignKey("AuthorrID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Librariann", "librarian")
                        .WithMany("Books")
                        .HasForeignKey("LibrarianID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("authorr");

                    b.Navigation("librarian");
                });

            modelBuilder.Entity("Library.BookAuthor", b =>
                {
                    b.HasOne("Library.Authorr", "Authorr")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorrID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Authorr");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Library.Catalog", b =>
                {
                    b.HasOne("Library.Libraryy", "library")
                        .WithMany("catalogs")
                        .HasForeignKey("LibraryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("library");
                });

            modelBuilder.Entity("Library.BookItem", b =>
                {
                    b.HasOne("Library.Account", "account")
                        .WithMany("BookItems")
                        .HasForeignKey("AccountID");

                    b.HasOne("Library.Catalog", "catalog")
                        .WithMany("BookItems")
                        .HasForeignKey("CatalogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Libraryy", "library")
                        .WithMany("bookItems")
                        .HasForeignKey("LibraryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");

                    b.Navigation("catalog");

                    b.Navigation("library");
                });

            modelBuilder.Entity("Library.Account", b =>
                {
                    b.Navigation("BookItems");
                });

            modelBuilder.Entity("Library.Authorr", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("books");
                });

            modelBuilder.Entity("Library.Book", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("Library.Catalog", b =>
                {
                    b.Navigation("BookItems");
                });

            modelBuilder.Entity("Library.Librariann", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library.Libraryy", b =>
                {
                    b.Navigation("accounts");

                    b.Navigation("bookItems");

                    b.Navigation("catalogs");
                });

            modelBuilder.Entity("Library.Patronn", b =>
                {
                    b.Navigation("account")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
