using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
                
        }
        public DbSet<Settings> Settings  { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet< Socialicons> Socialicons { get; set; }
        public DbSet<Navbar> Navbars { get; set; }
    }
}
