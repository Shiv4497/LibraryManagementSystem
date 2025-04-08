using LibraryManagement.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;

namespace LibraryManagement.API.Database
{
    public class LibraryManagementDbContext : DbContext
    {
        public LibraryManagementDbContext(DbContextOptions<LibraryManagementDbContext> options) : base(options)
        {
            
        }

        public DbSet<Authors> Authors { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
