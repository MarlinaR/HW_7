using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _6_3
{
    public class MContext : DbContext
    {
        public MContext(DbContextOptions<MContext> options)
   : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
    }
   
}
