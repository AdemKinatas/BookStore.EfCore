using BookStore.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DataAccess.Concrete.EntityFramework.Context
{
    public class BookStoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=BookStoreDb; User Id=sa;Password=123;");
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreBook> StoreBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().Property(a => a.FirstName).IsRequired();
            modelBuilder.Entity<Author>().Property(a => a.FirstName).HasMaxLength(100);
            modelBuilder.Entity<Author>().Property(a => a.LastName).IsRequired();
            modelBuilder.Entity<Author>().Property(a => a.LastName).HasMaxLength(100);
            modelBuilder.Entity<Author>().Property(a => a.Biography).IsRequired();
            modelBuilder.Entity<Author>().Property(a => a.Biography).HasMaxLength(1500);

            modelBuilder.Entity<Book>().Property(b => b.BookName).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.BookName).HasMaxLength(250);
            modelBuilder.Entity<Book>().Property(b => b.Summary).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.Summary).HasMaxLength(1500);

            modelBuilder.Entity<Category>().Property(c => c.CategoryName).IsRequired();
            modelBuilder.Entity<Category>().Property(c => c.CategoryName).HasMaxLength(100);

            modelBuilder.Entity<Publisher>().Property(p => p.PublisherName).IsRequired();
            modelBuilder.Entity<Publisher>().Property(p => p.PublisherName).HasMaxLength(100);
            modelBuilder.Entity<Publisher>().Property(p => p.Address).IsRequired();
            modelBuilder.Entity<Publisher>().Property(p => p.Address).HasMaxLength(100);
            modelBuilder.Entity<Publisher>().Property(p => p.EMail).IsRequired();
            modelBuilder.Entity<Publisher>().Property(p => p.EMail).HasMaxLength(100);
            modelBuilder.Entity<Publisher>().Property(p => p.PhoneNumber).IsRequired();
            modelBuilder.Entity<Publisher>().Property(p => p.PhoneNumber).HasMaxLength(13);

            modelBuilder.Entity<Store>().Property(s => s.ShopName).IsRequired();
            modelBuilder.Entity<Store>().Property(s => s.ShopName).HasMaxLength(100);
            modelBuilder.Entity<Store>().Property(s => s.Address).IsRequired();
            modelBuilder.Entity<Store>().Property(s => s.Address).HasMaxLength(500);
            modelBuilder.Entity<Store>().Property(s => s.Email).IsRequired();
            modelBuilder.Entity<Store>().Property(s => s.Email).HasMaxLength(100);
            modelBuilder.Entity<Store>().Property(s => s.PhoneNumber).IsRequired();
            modelBuilder.Entity<Store>().Property(s => s.PhoneNumber).HasMaxLength(13);

            modelBuilder.Entity<Category>().HasOne(c => c.Parent).WithMany(c => c.Children);

            modelBuilder.Entity<StoreBook>().HasKey(sb => new { sb.BookId, sb.StoreId });

            modelBuilder.Entity<Author>()
            .HasMany<Book>(a => a.Books)
            .WithOne(b => b.Author)
            .HasForeignKey(b => b.AuthorId);

            modelBuilder.Entity<Book>()
            .HasOne<Publisher>(b => b.Publisher)
            .WithMany(p => p.Books)
            .HasForeignKey(b => b.PublisherId);
        }
    }
}
