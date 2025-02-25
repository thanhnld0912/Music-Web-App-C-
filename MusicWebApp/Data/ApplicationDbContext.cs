using Microsoft.EntityFrameworkCore;
using MusicWebApp.Models;
using System.Collections.Generic;

namespace MusicWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
