using BrowserTravelAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravelAPI.Services
{
    public class BrowserTravelDbcontext:DbContext
    {
        public BrowserTravelDbcontext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Author_Book>()
                    .HasOne(b => b.Book)
                    .WithMany(ba => ba.Author_Books)
                    .HasForeignKey(bi => bi.Book_id);
            modelBuilder.Entity<Author_Book>()
                    .HasOne(a => a.Author)
                    .WithMany(ba => ba.Author_Books)
                    .HasForeignKey(ai => ai.Author_id);
            modelBuilder.Entity<Book>()
                    .HasOne(a => a.Publisher)
                    .WithMany(ba => ba.Books)
                    .HasForeignKey(ai => ai.Publisher_id);
        
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author_Book> Author_Books { get; set; }
    }
}
